from typing import Callable

from aproximation._1d_approximation import Approximation
from pyscipopt import Model, quicksum


class PressureDistribution(Approximation):
    def __init__(self, p, threshold: int = 3,
                 optimizaiton_type: bool = True, file_name="approximation_1d.txt", simulation_id="id",
                 model: Model = None):
        self. _f_x1_: Callable = lambda x1: 2*(200-x1)**0.5
        Approximation.__init__(model.getVal(p), model.getVal(p), self._f_x1_, threshold, optimizaiton_type, file_name, simulation_id, model)

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
