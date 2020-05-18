from constants_global.constants import gas_density_normal, compressibility_factor_normal, temperature_normal, \
    pressure_normal, reduced_temperature, pseudo_critical_pressure
from model.network.connection import Connection
import numpy as np

# from pyscipopt import Model, quicksum


from model.network.node import Node


class Pipe(Connection):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.length = float
        self.diameter = float
        self.roughness = float
        self.heat_transfer_coeff = float
        self.friction_factor = None
        self.gas_density_real: float = None
        self.compressibility_factor_real: float = None

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'Pipe id = {} from = {} to = {} length = {} diameter = {} roughness = {} pressre_max = {} ' \
               'heat_transfer_coeff ={}\n'.format(self.id, self._from, self.to, self.length, self.diameter,
                                                  self.roughness,
                                                  self.pressure_max,
                                                  self.heat_transfer_coeff)

    def calculate_friction_factor(self):
        self.friction_factor = (2 * np.log10(self.diameter / self.roughness) + 1.138) ** (
            -2) if self.roughness != 0 else 0

    def calculate_gas_density_real(self, pressure: float, temperature: float, compressibility_factor_real: float):
        self.gas_density_real = (
                                        gas_density_normal * compressibility_factor_normal * temperature_normal) / pressure_normal * \
                                (pressure) / (compressibility_factor_real * temperature)

    def calculate_compressibility_factor_real(self):
        self.compressibility_factor_real = 1 - 3.52 * reduce_pressure * np.e ** (
                -2.26 * reduced_temperature) + 0.247 * reduce_pressure ** 2 * np.e ** (-1.878 * reduced_temperature)

    def calculate_reduced_pressure(self, pressure: float):
        global reduce_pressure
        reduce_pressure = pressure / pseudo_critical_pressure
# todo this four functions calculate_friction_factor, calculate_gas_density_real, calculate_compressibility_factor_real, calculate_compressibility_factor_real
# todo are invoked for each pipe
