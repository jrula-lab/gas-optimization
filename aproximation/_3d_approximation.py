from typing import Callable, List, Tuple, Dict

from pyscipopt import Model, quicksum
import numpy as np

from logger.logger import Logger


class _3Dpoint:
    def __init__(self):
        self._lambda: int = None
        self._x1: float = None
        self._x2: float = None
        self._x3: float = None
        self._f_x1_x2_x3: float = None

    def __str__(self) -> str:
        return "lambda: {}, _x1: {}, _x2: {} _x3: {}. _f_x1_x2_x3: {} ".format(self._lambda, self._x1, self._x2,
                                                                               self._x3, self._f_x1_x2_x3)


class _3dMesh:

    def __init__(self, x1_min: float, x1_max: float, x2_min: float, x2_max: float, x3_min: float, x3_max: float,
                 _f_x1_x2_x3: Callable, threshold: int):
        self._f_x1_x2_x3: Callable = _f_x1_x2_x3
        self.x1_min: float = x1_min
        self.x1_max: float = x1_max
        self.x2_min: float = x2_min
        self.x2_max: float = x2_max
        self.x3_min: float = x3_min
        self.x1_max: float = x3_max
        self.threshold: int = threshold + 1
        self.x1_delta: float = (x1_max - x1_min) / threshold
        self.x2_delta: float = (x2_max - x2_min) / threshold
        self.x3_delta: float = (x3_max - x3_min) / threshold
        self.Matrix: List[List[List[_3Dpoint]]] = [
            [[_3Dpoint() for _ in range(threshold + 1)] for _ in range(threshold + 1)] for _ in range(threshold + 1)]
        self.simplices_list: List[Tuple] = []
        self.lambda_dict = {}
        self.initialize_matrix()

    def __str__(self) -> str:
        matrix: str = ''
        for surface in self.Matrix:
            for row in surface:
                for point in row:
                    matrix = matrix + point.__str__()
                matrix = matrix + "\n"
            matrix = matrix + "\n\n"
        return matrix

    def initialize_matrix(self):
        x3 = self.x3_min
        i: int = 0
        for surface in self.Matrix:
            x2 = self.x2_min
            for row in surface:
                x1 = self.x1_min
                for point in row:
                    point._x1 = x1
                    point._x2 = x2
                    point._x3 = x3
                    point._f_x1_x2_x3 = self._f_x1_x2_x3(x1, x2, x3)
                    x1 = x1 + self.x1_delta
                    self.lambda_dict[i] = None
                    point._lambda = i
                    i = i + 1
                x2 = x2 + self.x2_delta
            x3 = x3 + self.x3_delta

    def get_number_of_points(self):
        return self.threshold ** 3

    def get_tetrahedron_first(self, x1, x2, x3) -> Tuple:
        return (
            self.lambda_dict[self.Matrix[x1][x2][x3]._lambda], self.lambda_dict[self.Matrix[x1 + 1][x2][x3]._lambda], \
            self.lambda_dict[self.Matrix[x1 + 1][x2 + 1][x3]._lambda], self.lambda_dict[
                self.Matrix[x1 + 1][x2 + 1][x3 + 1]._lambda])

    def get_tetrahedron_second(self, x1, x2, x3) -> Tuple:
        return (
            self.lambda_dict[self.Matrix[x1][x2][x3]._lambda], self.lambda_dict[self.Matrix[x1 + 1][x2][x3]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2][x3 + 1]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2 + 1][x3 + 1]._lambda])

    def get_tetrahedron_third(self, x1, x2, x3) -> Tuple:
        return (
            self.lambda_dict[self.Matrix[x1][x2][x3]._lambda], self.lambda_dict[self.Matrix[x1][x2 + 1][x3]._lambda],
            self.lambda_dict[self.Matrix[x1][x2 + 1][x3 + 1]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2 + 1][x3 + 1]._lambda])

    def get_tetrahedron_fourth(self, x1, x2, x3) -> Tuple:
        return (
            self.lambda_dict[self.Matrix[x1][x2][x3]._lambda], self.lambda_dict[self.Matrix[x1][x2 + 1][x3]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2 + 1][x3]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2 + 1][x3 + 1]._lambda])

    def get_tetrahedron_fifth(self, x1, x2, x3) -> Tuple:
        return (
            self.lambda_dict[self.Matrix[x1][x2][x3]._lambda], self.lambda_dict[self.Matrix[x1][x2][x3 + 1]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2][x3 + 1]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2 + 1][x3 + 1]._lambda])

    def get_tetrahedron_sixth(self, x1, x2, x3) -> Tuple:
        return (
            self.lambda_dict[self.Matrix[x1][x2][x3]._lambda], self.lambda_dict[self.Matrix[x1][x2][x3 + 1]._lambda],
            self.lambda_dict[self.Matrix[x1][x2 + 1][x3 + 1]._lambda],
            self.lambda_dict[self.Matrix[x1 + 1][x2 + 1][x3 + 1]._lambda])

    def get_prism(self, x1, x2, x3) -> List[Tuple]:
        return [self.get_tetrahedron_first(x1, x2, x3), self.get_tetrahedron_second(x1, x2, x3),
                self.get_tetrahedron_third(x1, x2, x3),
                self.get_tetrahedron_fourth(x1, x2, x3), self.get_tetrahedron_fifth(x1, x2, x3),
                self.get_tetrahedron_sixth(x1, x2, x3)]

    def get_simplices_list(self) -> List:
        simplices_list: List = []
        for x3 in range(len(self.Matrix) - 1):
            for x2 in range(len(self.Matrix[x3]) - 1):
                for x1 in range(len(self.Matrix[x2][x3]) - 1):
                    simplices_list = simplices_list + self.get_prism(x1, x2, x3)
        return simplices_list

    def get_credential_list(self) -> Tuple[List[float], List[float], List[float], List[float], Dict]:
        x1_list: List[float] = []
        x2_list: List[float] = []
        x3_list: List[float] = []
        f_x1_x2_x3_list: List[float] = []
        for surface in self.Matrix:
            for row in surface:
                for point in row:
                    x1_list.append(point._x1)
                    x2_list.append(point._x2)
                    x3_list.append(point._x3)
                    f_x1_x2_x3_list.append(point._f_x1_x2_x3)
        return (x1_list, x2_list, x3_list, f_x1_x2_x3_list, self.lambda_dict)


class Approximation(Logger):

    def __init__(self, x1_min: float, x1_max: float, x2_min: float, x2_max: float, x3_min: float, x3_max, f_x1_x2_x3:
    Callable, threshold: int = 3, optimization_type: bool = True, file_name="approximation_3d.txt", simulation_id="id", model=None):
        Logger.__init__(self, file_name)
        self.x1_min: float = x1_min
        self.x1_max: float = x1_max
        self.x2_min: float = x2_min
        self.x2_max: float = x2_max
        self.x3_min: float = x3_min
        self.x3_max: float = x3_max
        self.mesh_3d: _3dMesh = _3dMesh(x1_min, x1_max, x2_min, x2_max, x3_min, x3_max, f_x1_x2_x3, threshold)
        self.model = model
        self.f_x1_x2_x3 = f_x1_x2_x3
        self.optimization_type = optimization_type
        self.simulation_id = simulation_id

    def add_constraints(self, _lambda, x1, x2, x3, f_x1_x2_x3_list):
        triangle_active = {}
        self.model.addCons(quicksum(_lambda[i] for i in _lambda) == 1)
        simplices = self.mesh_3d.get_simplices_list()
        for i in range(len(simplices)):
            triangle_active[i] = self.model.addVar(name="y[%d]" % i, vtype="B")

        self.model.addCons(quicksum(triangle_active[i] for i in triangle_active) == 1)

        for j, tetrahedron_point in enumerate(simplices):
            self.model.addCons(quicksum(k for k in tetrahedron_point) >= triangle_active[j])

        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) <= self.x1_max)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) >= self.x1_min)

        self.model.addCons(quicksum(_lambda[i] * x2[i] for i in range(len(x2))) <= self.x2_max)
        self.model.addCons(quicksum(_lambda[i] * x2[i] for i in range(len(x2))) >= self.x2_min)

        self.model.addCons(quicksum(_lambda[i] * x3[i] for i in range(len(x3))) <= self.x3_max)
        self.model.addCons(quicksum(_lambda[i] * x3[i] for i in range(len(x3))) >= self.x3_min)

        self.model.addCons(quicksum(_lambda[i]*x2[i] for i in  range(len(x2))) - quicksum(_lambda[i]*x1[i] for i in range(len(x1))) >=2000000.0)

    def model_definition(self):
        x1_list, x2_list, x3_list, f_x1_x2_x3_list, lambda_dict = self.mesh_3d.get_credential_list()
        for i in range(len(lambda_dict)):
            lambda_dict[i] = self.model.addVar(lb=0, ub=1, name="L[%d]" % i)
        self.add_constraints(lambda_dict, x1_list, x2_list, x3_list, f_x1_x2_x3_list)

        self.model.setObjective(quicksum(lambda_dict[i] * f_x1_x2_x3_list[i] for i in range(len(f_x1_x2_x3_list))),
                                "minimize" if self.optimization_type else "maximize")
        self.model.setRealParam("limits/gap", 1e-12)
        self.model.setRealParam("limits/absgap", 1e-12)
        self.model.setRealParam("numerics/feastol", 1e-9)
        self.model.optimize()
        return self.print_approximation_results(lambda_dict, x1_list, x2_list, x3_list, f_x1_x2_x3_list)

    def print_approximation_results(self, _lambda, x1, x2, x3, f_x1_x2_x3_list):
        self.f.write("Simulation id is {}\n".format(self.simulation_id))
        x1 = np.sum(np.array([x1[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        x2 = np.sum(np.array([x2[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        x3 = np.sum(np.array([x3[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        f_x1_x2_x3 = np.sum(np.array([f_x1_x2_x3_list[i] * self.model.getVal(_lambda[i]) for i in _lambda]))
        self.f.write("x1: {} x2: {} x3: {} L(f(x1, x2, x3)): {} fx1_x2_x3(x1, x2, x3): {} error: {}\n"
                     .format(x1, x2, x3, f_x1_x2_x3, self.f_x1_x2_x3(x1, x2, x3),
                             f_x1_x2_x3 - self.f_x1_x2_x3(x1, x2, x3)))
        self.f.close()
        return f_x1_x2_x3, x1, x2, x3


# mesh: _3dMesh = _3dMesh(0.0, 1.0, 0.0, 1.0, 0.0, 1.0,
#                         lambda x1, x2, x3: 6 * x1 + 0.5 * x2 + 4 * x3 - 2 * x1 ** 2 - 1.5 * x2 ** 2 - 1.75 * x3 ** 2, 3)
# print(mesh)
# print(mesh.get_simplices_list())
# x1, x2, x3, f, _lambda, lambda_list = mesh.get_credential_list()
# print(len(x1))
# print(len(x2))
# print(len(x3))
# print(len(f))
# print(len(_lambda))
# approximation = Approximation(2.0, 86.0, 2.0, 86.0, 0.0, 1.0,
#                               lambda x1, x2,
#                                      x3: 6 * x1 + 0.5 * x2 + 4 * x3 - 2 * x1 ** 2 - 1.5 * x2 ** 2 - 1.75 * x3 ** 2, 3)
# #
# approximation.model_definition()


# approximation = Approximation(0.00001, 86, 0.00001, 86, 60, 260,
#                               lambda x1, x2,
#                                      x3: 0.03*((x2/x1)**(0.296/1.296)-1)*x3, 3)
# approximation.model_definition()

# do not burden algorithm with big number

def approximation_checker(x1, x2, x3):
    return ((x2 / x1) ** (0.296 / 1.296) - 1) * x3

# print(approximation_checker(20.0, 21, 200.0))
#
# approximation = Approximation(-2, 0, -2, 0, 0, 1,
#                               lambda x1, x2,
#                                      x3: x1 ** 2 + 2.5 - x3 ** 2, 10)
# approximation.model_definition()
