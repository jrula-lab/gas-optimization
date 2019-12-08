from model.network.connection import Connection


class Pipe(Connection):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.length = float
        self.diameter = float
        self.roughness = float
        self.pressure_max = float
        self.pressure_min = float
        self.heat_transfer_coeff = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()