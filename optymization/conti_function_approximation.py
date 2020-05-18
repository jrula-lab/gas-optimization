from typing import Callable

from aproximation._1d_approximation import Approximation
from pyscipopt import Model, quicksum
import numpy as np

from constants_global.constants import compressibility_factor_normal, temperature_normal, pressure_normal, \
    gas_temperature, gravitational_acceleration, gas_density_normal, compressibility_factor_papay_formula
from model.network.pipe import Pipe

#todo to test
class ContiFunction(Approximation):

    def __init__(self, pipe: Pipe, model: Model):
        self.pipe_constant_1 = ((np.pi * pipe.diameter ** 2) / 4) * (
                compressibility_factor_normal * temperature_normal) / (pressure_normal * gas_temperature)

        self.pressure_function: Callable = lambda p: p / compressibility_factor_papay_formula(p)

        self.conti_function: Callable = lambda p: self.pipe_constant_1 * self.pressure_function(p)

        Approximation.__init__(self, pipe.pressure_min, pipe.pressure_max,
                               self.conti_function, file_name="conti_function.txt",
                               simulation_id="pipe_id = {}".format(pipe.id), model=model)

    def _model_definition(self, pipe: Pipe, variable_dict={}):
        x1, f_x1, _lambda = self.mesh1d.get_credential_list()
        for i in range(len(_lambda)):
            _lambda[i] = self.model.addVar(lb=0, ub=1, name="L[%d]" % i)

        self.add_constraint(_lambda, x1, f_x1)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == pipe.p_e)
        variable_dict[pipe.id]= self.model.addVar(lb = 0.0, ub =0.0, vtype='C')
        self.model.addCons(quicksum(_lambda[i] * f_x1[i] for i in range(len(f_x1))) ==variable_dict[pipe.id])




