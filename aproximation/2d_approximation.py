from typing import Callable, List, Tuple, Dict
from logger.logger import Logger
from pyscipopt import Model, quicksum
import numpy as np




class _2DPoint:

    def __init__(self):
        self._lambda: int = None
        self._x1: float = None
        self._x2: float = None
        self._f_x1_x2: float = None

    def __str__(self) -> str:
        return "_lambda: {}, _x1: {}, _x2: {}, _f_x1_x2: {}".format(self._lambda, self._x1, self._x2, self._f_x1_x2)


class _2DMesh:

    def __init__(self, x1_min: float, x1_max: float, x2_min: float, x2_max: float, _f_x1_x2: Callable, threshold: int):
        self._f_x1_x2: Callable = _f_x1_x2
        self.x1_min: float = x1_min
        self.x1_max: float = x1_max
        self.x2_min: float = x2_min
        self.x2_max: float = x2_max
        self.x1_delta: float = (x1_max - x1_min) / threshold
        self.x2_delta: float = (x2_max - x2_min) / threshold
        self.threshold: int = threshold + 1
        self.Matrix: List[List[_2DPoint]] = [[_2DPoint() for _ in range(threshold + 1)] for _ in range(threshold + 1)]
        self.simplices_list: List[Tuple] = []
        self.lambda_dict = {}
        self.initialize_matrix()

    def __str__(self) -> str:
        matrix: str = ''
        for M1 in self.Matrix:
            for P in M1:
                matrix = matrix + P.__str__()
            matrix = matrix + '\n'
        return matrix

    def initialize_matrix(self):
        x2 = self.x2_min
        i: int = 0
        for row in self.Matrix:
            x1 = self.x1_min
            for point in row:
                point._x1 = x1
                point._x2 = x2
                point._f_x1_x2 = self._f_x1_x2(x1, x2)
                x1 = x1 + self.x1_delta
                self.lambda_dict[i] = None
                point._lambda = i
                i = i + 1
            x2 = x2 + self.x2_delta

    def get_number_of_points(self) -> int:
        return self.threshold ** 2

    def get_credential_list(self) -> Tuple[List[float], List[float], List[float], Dict]:
        x1_list: List[float] = []
        x2_list: List[float] = []
        fx1_x2_list: List[float] = []
        for row in self.Matrix:
            for point in row:
                x1_list.append(point._x1)
                x2_list.append(point._x2)
                fx1_x2_list.append(point._f_x1_x2)
        return (x1_list, x2_list, fx1_x2_list, self.lambda_dict)

    def get_simplices_list(self) -> List[Tuple]:
        for x2 in range(len(self.Matrix) - 1):
            for x1 in range(len(self.Matrix[x2])):
                if x1 == 0:
                    self.simplices_list.append(self.get_triangle_base_down(x1, x2))
                elif x1 == len(self.Matrix[x2]) - 1:
                    self.simplices_list.append(self.get_triangle_base_up(x1, x2))
                else:
                    self.simplices_list.append((self.get_triangle_base_up(x1, x2)))
                    self.simplices_list.append((self.get_triangle_base_down(x1, x2)))
        return self.simplices_list

    def get_triangle_base_up(self, x1, x2) -> Tuple:
        return self.lambda_dict[self.Matrix[x2][x1 - 1]._lambda], self.lambda_dict[self.Matrix[x2][x1]._lambda], \
               self.lambda_dict[self.Matrix[x2 + 1][x1]._lambda]

    def get_triangle_base_down(self, x1, x2) -> Tuple:
        return self.lambda_dict[self.Matrix[x2][x1]._lambda], self.lambda_dict[self.Matrix[x2 + 1][x1]._lambda], \
               self.lambda_dict[self.Matrix[x2 + 1][x1 + 1]._lambda]


class Approximation(Logger):

    def __init__(self, x1_min: float, x1_max: float, x2_min: float, x2_max: float, _f_x1_x2: Callable, threshold: int=3,
                 optimization_type: bool = True, file_name="approximation_2d.txt", simulation_id="id"):
        Logger.__init__(self, file_name)
        self.x1_max = x1_max
        self.x1_min = x1_min
        self.x2_max = x2_max
        self.x2_min = x2_min
        self.mesh_2d = _2DMesh(x1_min, x1_max, x2_min, x2_max, _f_x1_x2, threshold)
        self.model = Model('Piecewise Linear Approximation of 2D function')
        self.fx1_x2 = _f_x1_x2
        self.optimization_type = optimization_type
        self.simulation_id = simulation_id

    def add_constraints(self, _lambda, x1, x2):
        triangle_active = {}
        # 1
        self.model.addCons(quicksum(_lambda[i] for i in _lambda) == 1)
        simplices = self.mesh_2d.get_simplices_list()
        for i in range(len(simplices)):
            triangle_active[i] = self.model.addVar(name="y[%d]" % i, vtype="B")
        # 2
        self.model.addCons(quicksum(triangle_active[i] for i in triangle_active) == 1)
        # 3
        for j, triangle_point in enumerate(simplices):
            self.model.addCons(quicksum(k for k in triangle_point) >= triangle_active[j])
        # 4
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) <= self.x1_max)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) >= self.x1_min)
        # 5
        self.model.addCons(quicksum(_lambda[i] * x2[i] for i in range(len(x2))) <= self.x2_max)
        self.model.addCons(quicksum(_lambda[i] * x2[i] for i in range(len(x2))) >= self.x2_min)
        self.model.addCons((5 * quicksum(_lambda[i] * x1[i] for i in range(len(x1))) + quicksum(_lambda[i] * x2[i] \
                                                                                                for i in
                                                                                                range(len(x2)))) >= 3)

    def _model_definition(self):
        x1_list, x2_list, fx1_x2_list, _lambda_list = self.mesh_2d.get_credential_list()
        for i in range(len(_lambda_list)):
            _lambda_list[i] = self.model.addVar(lb=0, ub=1, name="L[%d]" % i)
        self.add_constraints(_lambda_list, x1_list, x2_list)
        self.model.setObjective(quicksum(_lambda_list[i] * fx1_x2_list[i] for i in range(len(fx1_x2_list))),
                                "minimize" if self.optimization_type else "maximize")
        self.model.optimize()
        return self.print_approximation_results(_lambda_list, x1_list, x2_list, fx1_x2_list)

    def print_approximation_results(self, _lambda, x1, x2, fx1_x2_list):
        self.f.write("Simulation id is {}\n".format(self.simulation_id))
        x1 = np.sum(np.array([x1[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        x2 = np.sum(np.array([x2[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        fx1_x2 = np.sum(np.array([fx1_x2_list[i]*self.model.getVal(_lambda[i]) for i in _lambda]))
        self.f.write("x1: {} x2: {} L(f(x1, x2)): {} fx1_x2(x1, x2): {} error: {}\n".format(x1, x2, fx1_x2, self.fx1_x2(x1, x2), fx1_x2-self.fx1_x2(x1, x2)))
        self.f.close()


approximation = Approximation(0.0, 1.0, 0, 1.0, lambda x1, x2: -4 * x1 ** 2 - 3 * x2 ** 2 + 6 * x1 + 0.5 * x2, 3)
approximation._model_definition()


# approximation = Approximation(0.0, 10, 0.0, 10, lambda x1, x2: (x1**2+x2**2-1)**2, 100)
# approximation._model_definition()
