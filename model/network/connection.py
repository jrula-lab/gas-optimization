from model.network.element import Element


class Connection(Element):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self._from: str
        self.to: str
        self.flow_min = float
        self.flow_max = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self):
        return "_from: {}, to: {}, flow_min: {}, flow_max: {}".format(self._form, self.to,
                                                                                            self.flow_min,
                                                                                            self.flow_max)
