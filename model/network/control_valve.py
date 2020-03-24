from model.network.connection import Connection


class ControlValve(Connection):

    def __init__(self, id, alias) -> None:
        super().__init__(id, alias)
        self.pressure_diff_min = float
        self.pressure_diff_max = float
        self.pressure_in_min = float
        self.pressure_out_max = float
        self.pressure_loss_in = float
        self.pressure_loss_out = float

    def __eq__(self, o: object) -> bool:
        return super().__eq__(o)

    def __hash__(self) -> int:
        return super().__hash__()

    def __str__(self) -> str:
        return 'ControlValve id = {} from = {} to = {} pressure_diff_min = {} pressure_diff_max = {} ' \
                                     'pressure_in_min = {} pressre__in_max = {} ' \
                                     'pressure_loss_in ={} pressure_loss_out ={}'.format(self.id, self._from, self.to,
                                                                                         self.pressure_diff_min,
                                                                                         self.pressure_diff_max,
                                                                                         self.pressure_in_min,
                                                                                         self.pressure_out_max,
                                                                                         self.pressure_loss_in,
                                                                                         self.pressure_loss_out)
