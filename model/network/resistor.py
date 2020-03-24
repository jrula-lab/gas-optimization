from model.network.connection import Connection


class Resistor(Connection):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.drag_factor = float
        self.diameter = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self):
        return "ShortPipe: id: {}, alias: {}, drag_factor: {}, diameter: {}\n".format(self.id, self.alias,
                                                                                      self.drag_factor, self.diameter)
