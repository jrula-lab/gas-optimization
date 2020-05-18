from model.network.element import Element
from model.network.vertex import Vertex


class Node(Element, Vertex):
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

    def __str__(self):
        return "Node: geo_long: {}, geo_lat: {}, x: {}, y: {}, height: {}, pressure_min: {}, pressure_max: {}, " \
               "from_pipes: {}, to_pipes: {}".format(
            self.geo_long, self.geo_lat, self.x, self.y, self.height, self.pressure_min, self.pressure_max,
            self.from_pipes, self.to_pipes)





