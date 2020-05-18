from typing import Callable

from aproximation._2d_approximation import Approximation
from pyscipopt import Model, quicksum
import numpy as np

from constants_global.constants import gas_density_normal, pressure_normal, gas_temperature, \
    compressibility_factor_normal, temperature_normal, compressibility_factor_papay_formula
from model.network.pipe import Pipe

#todo test it
class FrictionFunctionApproximation(Approximation):

    def __init__(self, pipe: Pipe, model: Model):
        self.pipe_constant_1 = (pipe.friction_factor/(2*pipe.diameter)+1/pipe.length)*(gas_density_normal*pressure_normal*gas_temperature)/\
                               (((np.pi*pipe.diameter**2)/4)**2*compressibility_factor_normal*temperature_normal)
        self.inter_friction_function: Callable = lambda p,q: (q**2*compressibility_factor_papay_formula(p))/p
        self.friction_function: Callable = lambda p,q: self.pipe_constant_1*self.inter_friction_function(p,q)
        Approximation.__init__(self, pipe.pressure_min, pipe.pressure_max, pipe.flow_min, pipe.flow_max, self.friction_function, file_name="friction_function.txt",
                               simulation_id="pipe_id = {}".format(pipe.id), model= model)

    def model_definition(self, pipe: Pipe):
        x1, x2, fx1_x2, _lambda = self.mesh_2d.get_credential_list()
        for i in range(len(_lambda)):
            _lambda[i] = self.model.addVar(lb=0, ub=1, name="L[%d]" % i)
        self.add_constraints(_lambda, x1, x2, fx1_x2)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == pipe.p_e)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == pipe.q_e)
        y = self.model.addVar(lb = 0.0, ub = None)
        self.model.addCons(quicksum(_lambda[i] * fx1_x2[i] for i in range(len(fx1_x2))) == y)
        return y
