from constants_global.constants import calculate_reduced_temperature, read_molar_mass, read_pseudo_critical_pressure, \
    read_gas_calorific_value
from model.network.node import Node
from model.scenario.scenario_node import ScenarioNode


class Source(Node):
    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.gas_temperature = float
        self.calorific_value = float
        self.norm_density = float
        self.coeff_a_heat_capacity = float
        self.coeff_b_heat_capacity = float
        self.coeff_c_heat_capacity = float
        self.molar_mass = float
        self.pseudo_critical_pressure = float
        self.pseudo_critical_temperature = float
        self.pressure_lower: float = None
        self.pressure_upper: float = None


    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'Source: id = {} alias = {} geo_long={} geo_lat={} x={} y={} height={} pressure_min={}' \
                    ' pressure_max={} flow_min={} flow_max={}' \
                    'gas_temperature={} calorifict_value={} norm_density={} coeff_a_heat={} coeff_b_heat={} coeff_' \
                    'c_heat={} molar_mass={} pseudo_critical_pressure={}' \
                    'presudo_critical_temperature={}, flow_in_out = {}\n'.format(self.id, self.alias, self.geo_long, self.geo_lat, self.x,
                                                               self.y, self.height, self.pressure_min,
                                                               self.pressure_max,
                                                               self.flow_min, self.flow_max,
                                                               self.gas_temperature, self.calorific_value,
                                                               self.norm_density,
                                                               self.coeff_a_heat_capacity, self.coeff_b_heat_capacity,
                                                               self.coeff_c_heat_capacity,
                                                               self.molar_mass, self.pseudo_critical_pressure,
                                                               self.pseudo_critical_temperature, self.flow_in_out)

    @staticmethod
    def read_constant_data(source_list: {}):
        source: Source = list(source_list.values())[0]
        calculate_reduced_temperature(source.pseudo_critical_temperature, source.gas_temperature+273.15)
        read_molar_mass(source.molar_mass)
        read_pseudo_critical_pressure(source.pseudo_critical_pressure)
        read_gas_calorific_value(source.calorific_value)

    def assign_values_from_scenario_node(self, node: ScenarioNode):
        self.flow_in_out = node.flow
        self.pressure_upper = node.pressure_upper
        self.pressure_lower = node.pressure_low

