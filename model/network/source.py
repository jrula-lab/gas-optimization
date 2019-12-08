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
