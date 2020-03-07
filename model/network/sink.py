from model.network.node import Node


class Sink(Node):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.flow_min = float
        self.flow_max = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'Source: id = {} alias = {} geo_long={} geo_lat={} x={} y={} height={} pressure_min={} ' \
               'pressure_max={} flow_min={} flow_max={}' \
            .format(self.id, self.alias, self.geo_long, self.geo_lat, self.x,
                    self.y, self.height, self.pressure_min, self.pressure_max,
                    self.flow_min, self.flow_max)
