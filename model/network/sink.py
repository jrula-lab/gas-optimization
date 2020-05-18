from model.network.node import Node
from model.scenario.scenario_node import ScenarioNode


class Sink(Node):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.pressure_lower: float = None
        self.pressure_upper: float = None

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'Sink: id = {} alias = {} geo_long={} geo_lat={} x={} y={} height={} pressure_min={} ' \
               'pressure_max={} flow_min={} flow_max={}, flow_in_out = {}\n' \
            .format(self.id, self.alias, self.geo_long, self.geo_lat, self.x,
                    self.y, self.height, self.pressure_min, self.pressure_max,
                    self.flow_min, self.flow_max, self.flow_in_out)

    def assign_values_from_scenario_node(self, node: ScenarioNode):
        self.flow_in_out = node.flow
        self.pressure_upper = node.pressure_upper
        self.pressure_lower = node.pressure_low
