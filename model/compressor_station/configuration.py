class Configuration:
    def __init__(self, conf_id, nr_of_serial_stages) -> None:
        self.conf_id = conf_id
        self.nr_of_serial_stages = nr_of_serial_stages
        self.stage_nr = float
        self.nr_of_parallel_units = float
        self.compressor_id = str
        self.nominal_speed = float

    def __str__(self) -> str:
        return 'conf_id={} nr_of_serial_stages={} stage_nr={} nr_of_parallel_units={} compressor_id={}' \
               ' nominal_speed={}'.format(self.conf_id, self.nr_of_serial_stages, self.stage_nr,
                                          self.nr_of_parallel_units, self.compressor_id, self.nominal_speed)
