from typing import Callable

from aproximation._3d_approximation import Approximation
from pyscipopt import Model, quicksum

from constants_global.constants import gas_temperature, gravitational_acceleration, gas_density_normal, \
    compressibility_factor_papay_formula, \
    isentropic_exponent, universal_gas_constant, molar_mass, adiabatic_efficiency, gas_calorific_value
from model.network.compressor_station import CompressorStation


class GasFlowCompressorConsumptionApproximation(Approximation):

    def __init__(self,  model: Model, compressor: CompressorStation):
        self.adiabatic_head_constant =(isentropic_exponent / (isentropic_exponent - 1) * ((universal_gas_constant/1000) * gas_temperature) / (gravitational_acceleration*molar_mass))
        self.adiabatic_head_function: Callable = lambda p_in, p_out: self.adiabatic_head_constant*compressibility_factor_papay_formula(p_in) * (
                (p_out / p_in) ** ((isentropic_exponent - 1) / isentropic_exponent) - 1)
        self.power_function: Callable =lambda p_in,p_out,q: (gravitational_acceleration/3600)*gas_density_normal*q*self.adiabatic_head_function(p_in, p_out)
        Approximation.__init__(self, compressor.pressure_min, compressor.pressure_max, compressor.pressure_min, compressor.pressure_max, compressor.flow_min,
                               compressor.flow_max,
                               file_name="gas_flow_compressor_consumption_approximation.txt",
                               simulation_id="compressor_id = {}".format(compressor.id)
                               , model=model, f_x1_x2_x3=self.power_function)

    def _model_definition(self, compressor: CompressorStation):
        x1, x2, x3, f_x1_x2_x3, _lambda = self.mesh_3d.get_credential_list()
        for i in range(len(_lambda)):
            _lambda[i] = self.model.addVar(lb=0, ub=1, name="L[%d]" % i)
        self.add_constraints(_lambda, x1, x2, x3, f_x1_x2_x3)
        self.model.addCons(quicksum(_lambda[i]*x2[i] for i in  range(len(x2))) - quicksum(_lambda[i]*x1[i] for i in range(len(x1))) <=compressor.pressure_out_max-compressor.pressure_in_min)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == compressor.p_b)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == compressor.p_e)
        self.model.addCons(quicksum(_lambda[i] * x1[i] for i in range(len(x1))) == compressor.q_b)
        y = self.model.addVar(lb = 0.0, ub = None)
        self.model.addCons(quicksum(_lambda[i] * f_x1_x2_x3[i] for i in range(len(f_x1_x2_x3))) == y)



        # theoretical_compressor_power,x1, x2, x3 = self.model_definition()
        # practical_compressor_power = theoretical_compressor_power/adiabatic_efficiency
        # drive_power = CompressorStation.energy_consumption_rate(practical_compressor_power)
        # compressor_cost = (drive_power)/(gas_calorific_value/(3.6*10**6))                       #kWh
        # return compressor_cost, x1, x2, x3
        return y