from model.network.connection import Connection


class Valve(Connection):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.pressure_diff_max = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()