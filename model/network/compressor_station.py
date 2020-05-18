from typing import Tuple, Callable

from constants_global.constants import reduced_temperature, pseudo_critical_pressure
from model.network.connection import Connection
import numpy as np

from utils.converters import convert_array_tuple_to_np_array
from utils.least_square_method import least_square_solution
from utils.visualize import draw_scatter_line_graph


class CompressorStation(Connection):
    energy_consumption_measurement: [Tuple] = None
    power_measurement: [Tuple] = None
    energy_consumption_rate: Callable = None  # this is b from equation y= b/(1000*Hu)
    maximum_power: Callable = None

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.pressure_loss_in = float
        self.pressure_loss_out = float
        self.pressure_in_min = float
        self.pressure_out_max = float
        self.compressibility_factor_real: float = None
        self.reduce_pressure: float = None
        # todo add filed read from file .net <drives>

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def calculate_compressibility_factor_real(self):
        self.compressibility_factor_real = 1 - 3.52 * reduce_pressure * np.e ** (
                -2.26 * reduced_temperature) + 0.247 * reduce_pressure ** 2 * np.e ** (-1.878 * reduced_temperature)

    def calculate_reduced_pressure(self, pressure: float):
        global reduce_pressure
        reduce_pressure = pressure / pseudo_critical_pressure

    # def calculate_adiabatic_height(self):

    @staticmethod
    def set_energy_power_measurement(consumption_measurement: [Tuple], power_measurement_list: [Tuple]) -> Tuple:
        CompressorStation.energy_consumption_measurement = consumption_measurement
        CompressorStation.power_measurement = power_measurement_list
        comp_power, energy_cons = convert_array_tuple_to_np_array(CompressorStation.energy_consumption_measurement)
        CompressorStation.energy_consumption_rate = least_square_solution(comp_power, energy_cons)
        # draw_scatter_line_graph(comp_power, energy_cons, function_equation=CompressorStation.energy_consumption_rate)
        comp_speed, max_power = convert_array_tuple_to_np_array(CompressorStation.power_measurement)
        CompressorStation.maximum_power = least_square_solution(comp_speed, max_power)
        # draw_scatter_line_graph(comp_speed, max_power, function_equation=CompressorStation.maximum_power)
        return (comp_power, energy_cons, comp_speed, max_power)

    def __str__(self):
        return  "pressure_loss_in: {}, pressure_loss_out: {}, pressure_in_min: {}, " \
                                     "pressure_out_max: {}, compressibility_factor: {}, reduced_pressure: {}".format(
            self.pressure_loss_in, self.pressure_loss_out, self.pressure_in_min, self.pressure_out_max,
            self.compressibility_factor_real, self.reduce_pressure
        )
