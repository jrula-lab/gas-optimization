

class ScenarioNode:
    def __init__(self, id) -> None:
        super().__init__()
        self.id = id
        self.pressure_low =float
        self.pressure_upper = float
        self.flow = float
        self.contract_pressure_max = float

    def __str__(self) -> str:
        return 'id={} pressure_low={} pressure_upper={} flow={} contract_pressure_max={}'.\
            format(self.id, self.pressure_low, self.pressure_upper, self.flow, self.contract_pressure_max)



