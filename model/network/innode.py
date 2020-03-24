from model.network.node import Node


class Innode(Node):
    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'InNode: id = {} alias = {} geo_long={} geo_lat={} x={} y={} height={} pressure_min={} ' \
                    'pressure_max={} ' \
                   .format(self.id, self.alias, self.geo_long, self.geo_lat, self.x,
                           self.y, self.height, self.pressure_min, self.pressure_max)
