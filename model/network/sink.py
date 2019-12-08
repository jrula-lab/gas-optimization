from model.network.node import Node


class Sink(Node):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.flow_min = float
        self.flow_max =float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()