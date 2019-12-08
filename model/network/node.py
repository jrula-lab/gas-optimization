from model.network.element import Element


class Node(Element):
    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.geo_long = float
        self.geo_lat = float
        self.x = float
        self.y = float
        self.height = float
        self.pressure_min = float
        self.pressure_max = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()
