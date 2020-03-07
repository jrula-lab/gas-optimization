from model.network.node import Node


# todo by default all attributes are public xd

class Source(Node):
    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.flow_min = float
        self.flow_max = float
        self.gas_temperature = float
        self.calorific_value = float
        self.norm_density = float
        self.coeff_a_heat_capacity = float
        self.coeff_b_heat_capacity = float
        self.coeff_c_heat_capacity = float
        self.molar_mass = float
        self.pseudo_critical_pressure = float
        self.pseudo_critical_temperature = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'Source: id = {} alias = {} geo_long={} geo_lat={} x={} y={} height={} pressure_min={} pressure_max={} flow_min={} flow_max={}' \
               'gas_temperature={} calorifict_value={} norm_density={} coeff_a_heat={} coeff_b_heat={} coeff_c_heat={} molar_mass={} pseudo_critical_pressure={}' \
               'presudo_critical_temperature={}'.format(self.id, self.alias, self.geo_long, self.geo_lat, self.x,
                                                        self.y, self.height, self.pressure_min, self.pressure_max,
                                                        self.flow_min, self.flow_max,
                                                        self.gas_temperature, self.calorific_value, self.norm_density,
                                                        self.coeff_a_heat_capacity, self.coeff_b_heat_capacity,
                                                        self.coeff_c_heat_capacity,
                                                        self.molar_mass, self.pseudo_critical_pressure,
                                                        self.pseudo_critical_temperature)
