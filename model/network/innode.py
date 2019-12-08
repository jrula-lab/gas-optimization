from model.network.node import Node


class Innode(Node):
    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()
