from typing import Callable

from aproximation._2d_approximation import Approximation
from pyscipopt import Model, quicksum
import numpy as np

from constants_global.constants import gas_density_normal, pressure_normal, gas_temperature, \
    compressibility_factor_normal, temperature_normal, compressibility_factor_papay_formula
from model.network.connection import Connection


class NormalFlowApproximation(Approximation):

    def __init__(self, connection: Connection, model: Model, incoming: bool = True):
        self.incoming = incoming
        self.flow_function: Callable = lambda p, q: (p * q) / (
                    pressure_normal * compressibility_factor_papay_formula(p))
        Approximation.__init__(self, connection.pressure_min, connection.pressure_max, connection.flow_min, connection.flow_max,
                               self.flow_function, model=model)

    def model_definition(self, pipe: Connection):
        x1, x2, fx1_x2, _lambda = self.mesh_2d.get_credential_list()
        for i in range(len(_lambda)):
            _lambda[i] = self.model.addVar(lb=0, ub=1, name="L[%d]" % i)
        self.add_constraints(_lambda, x1, x2, fx1_x2)
        if self.incoming:
            self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == pipe.p_e)
            self.model.addCons(quicksum(_lambda[i] * x2[i] for i in range(len(x2))) == pipe.q_e)

        else:
            self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == pipe.p_b)
            self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == pipe.q_b)


