from typing import Callable, List, Tuple, Dict
from pyscipopt import Model, quicksum

from logger.logger import Logger
import numpy as np


class _1DPoint:
    def __init__(self):
        self._lambda: int = None
        self._x1: float = None
        self._f_x1: float = None

    def __str__(self):
        return "lambda: {}, x1: {}, f_x1: {}".format(self._lambda, self._x1, self._f_x1)


class _1DMesh:

    def __init__(self, x1_min: float, x1_max: float, _f_x1: Callable, threshold: int):
        self._f_x1: Callable = _f_x1
        self.x1_min: float = x1_min
        self.x1_max: float = x1_max
        self.x1_delta: float = (self.x1_max - self.x1_min) / threshold
        self.threshold: int = threshold
        self.Matrix: List[_1DPoint] = [_1DPoint() for _ in range(threshold + 1)]
        self.simplices_list: List[Tuple] = []
        self.lambda_dict = {}
        self.initialize_matrix()

    def __str__(self):
        matrix: str = ''
        for P in self.Matrix:
            matrix = matrix + P.__str__()

        return matrix

    def initialize_matrix(self):
        x1 = self.x1_min
        i: int = 0
        for point in self.Matrix:
            point._x1 = x1
            point._f_x1 = self._f_x1(x1)
            x1 = x1 + self.x1_delta
            self.lambda_dict[i] = None
            point._lambda = i
            i = i + 1

    def get_number_of_points(self):
        return self.threshold

    def get_credential_list(self) -> Tuple[List[float], List[float], Dict]:
        x1_list = []
        f_x1_list = []
        for point in self.Matrix:
            x1_list.append(point._x1)
            f_x1_list.append(point._f_x1)
        return (x1_list, f_x1_list, self.lambda_dict)

    def get_simplices_list(self) -> List[Tuple]:
        for x1 in range(self.threshold - 1):
            self.simplices_list.append(tuple([self.Matrix[x1]._lambda, self.Matrix[x1 + 1]._lambda]))
        return self.simplices_list


class Approximation(Logger):

    def __init__(self, x1_min: float, x1_max: float, _f_x1_: Callable, threshold: int = 3,
                 optimizaiton_type: bool = True, file_name="approximation_1d.txt", simulation_id="id"):
        Logger.__init__(self, file_name)
        self.x1_min = x1_min
        self.x1_max = x1_max
        self.f_x1 = _f_x1_
        self.mesh1d: _1DMesh = _1DMesh(x1_min, x1_max, _f_x1_, threshold)
        self.model = Model("Piecewise Linear Approximation of 1D function")
        self.optimization_type = optimizaiton_type
        self.simulation_id = simulation_id

    def add_constraint(self, _lambda, x1):
        section_active = {}
        # 1
        self.model.addCons(quicksum(_lambda[i] for i in _lambda) == 1)
        simplices = self.mesh1d.get_simplices_list()
        for i in range(len(simplices)):
            section_active[i] = self.model.addVar(name="y[%d]" % i, vtype="B")
        # 2
        self.model.addCons(quicksum(section_active[i] for i in section_active) == 1)
        # 3
        for j, section_point in enumerate(simplices):
            self.model.addCons(quicksum(k for k in section_point) >= section_active[j])
        # 4
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) <= self.x1_max)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) >= self.x1_min)

    def mode_definition(self):
        x1_list, f_x1_list, lambda_dict = self.mesh1d.get_credential_list()
        for i in range(len(lambda_dict)):
            lambda_dict[i] = self.model.addVar(lb=0, ub=1, name="L[%d]" % i)

        self.add_constraint(lambda_dict, x1_list)
        self.model.setObjective(quicksum(lambda_dict[i] * f_x1_list[i] for i in range(len(f_x1_list))),
                                "minimize" if self.optimization_type else "maximize")
        self.model.optimize()
        return self.print_approximation_results(lambda_dict, x1_list, f_x1_list)

    def print_approximation_results(self, _lambda, x1, f_x1_list):
        self.f.write("Simulation id is {}\n".format(self.simulation_id))
        x1 = np.sum(np.array([x1[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        fx1_x2 = np.sum(np.array([f_x1_list[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        self.f.write("x1: {} L(f(x1, x2)): {} fx1_x2(x1, x2): {} error: {}\n".format(x1, fx1_x2, self.f_x1(x1),
                                                                                     fx1_x2 - self.f_x1(x1)))
        self.f.close()


approximation = Approximation(0.0, 4, lambda x1: x1 ** 5 - 3 * x1 ** 4 + 5, 10)
approximation.mode_definition()
