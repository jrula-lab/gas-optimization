class GasTurbine:
    def __init__(self, id) -> None:
        self.id = id
        self.energy_rate_fun_coeff_1 = float
        self.energy_rate_fun_coeff_2 = float
        self.energy_rate_fun_coeff_3 = float
        self.power_fun_coeff_1 = float
        self.power_fun_coeff_2 = float
        self.power_fun_coeff_3 = float
        self.power_fun_coeff_4 = float
        self.power_fun_coeff_5 = float
        self.power_fun_coeff_6 = float
        self.power_fun_coeff_7 = float
        self.power_fun_coeff_8 = float
        self.power_fun_coeff_9 = float

    def __str__(self) -> str:
        return 'id={} energy_rate_fun_coeff_1={} energy_rate_fun_coeff_2={} energy_rate_fun_coeff_3={} ' \
               'power_fun_coeff_1={}' \
               'power_fun_coeff_2={} power_fun_coeff_3={} power_fun_coeff_4={} power_fun_coeff_5={}' \
               ' power_fun_coeff_6={}' \
               'power_fun_coeff_7={} power_fun_coeff_8={} power_fun_coeff_9={}'. \
            format(self.id, self.energy_rate_fun_coeff_1, self.energy_rate_fun_coeff_2, self.energy_rate_fun_coeff_3,
                   self.power_fun_coeff_1, self.power_fun_coeff_2, self.power_fun_coeff_3, self.power_fun_coeff_4,
                   self.power_fun_coeff_5,
                   self.power_fun_coeff_6, self.power_fun_coeff_7, self.power_fun_coeff_8, self.power_fun_coeff_9)
