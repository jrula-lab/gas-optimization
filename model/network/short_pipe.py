from model.network.connection import Connection


class ShortPipe(Connection):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.pressure_diff_max = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'ShortPipe id = {} alias = {} flowMin = {} flowMax = {} pressure_diff_max = {}'.format(self.id,
                                                                                                      self.alias,
                                                                                                      self.flow_min,
                                                                                                      self.flow_max,
                                                                                                      self.pressure_diff_max)
