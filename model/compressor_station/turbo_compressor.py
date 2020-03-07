class TurboCompressor:

    def __init__(self, id) -> None:
        self.id = id
        self.speed_min = float
        self.speed_max = float
        self.n_isoline_coeff_1 = float
        self.n_isoline_coeff_2 = float
        self.n_isoline_coeff_3 = float
        self.n_isoline_coeff_4 = float
        self.n_isoline_coeff_5 = float
        self.n_isoline_coeff_6 = float
        self.n_isoline_coeff_7 = float
        self.n_isoline_coeff_8 = float
        self.n_isoline_coeff_9 = float
        self.eta_ad_isoline_coeff_1 = float
        self.eta_ad_isoline_coeff_2 = float
        self.eta_ad_isoline_coeff_3 = float
        self.eta_ad_isoline_coeff_4 = float
        self.eta_ad_isoline_coeff_5 = float
        self.eta_ad_isoline_coeff_6 = float
        self.eta_ad_isoline_coeff_7 = float
        self.eta_ad_isoline_coeff_8 = float
        self.eta_ad_isoline_coeff_9 = float
        self.surgeline_coeff_1 = float
        self.surgeline_coeff_2 = float
        self.surgeline_coeff_3 = float
        self.choke_line_coeff_1 = float
        self.choke_line_coeff_2 = float
        self.choke_line_coeff_3 = float
        self.efficiency_of_choke_line = float
        # todo maybe add surgeline messurments from 582 gaslib

    def __str__(self) -> str:
        return 'id ={} speed_min = {} speed_max = {} n_isoline_coeff_1 ={} n_isoline_coeff_2 = {} n_isoline_coeff_3 ={} ' \
               'n_isoline_coeff_4={} n_isoline_coeff_5={} n_isoline_coeff_6={} n_isoline_coeff_7={}' \
               'n_isoline_coeff_8={} n_isoline_coeff_9={} eta_ad_isoline_coeff_1={} eta_ad_isoline_coeff_2={} ' \
               'eta_ad_isoline_coeff_3={} eta_ad_isoline_coeff_4={} eta_ad_isoline_coeff_5={} eta_ad_isoline_coeff_6={}' \
               'eta_ad_isoline_coeff_7={} eta_ad_isoline_coeff_8={} eta_ad_isoline_coeff_9={} surgeline_coeff_1={} ' \
               'surgeline_coeff_2={} surgeline_coeff_3={} choke_line_coeff_1={}' \
               'choke_line_coeff_2={} choke_line_coeff_3={}'.format(self.id, self.speed_min, self.speed_max,
                                                                    self.n_isoline_coeff_1, self.n_isoline_coeff_2,
                                                                    self.n_isoline_coeff_3, self.n_isoline_coeff_4,
                                                                    self.n_isoline_coeff_5,
                                                                    self.n_isoline_coeff_6, self.n_isoline_coeff_7,
                                                                    self.n_isoline_coeff_8, self.n_isoline_coeff_9,
                                                                    self.eta_ad_isoline_coeff_1,
                                                                    self.eta_ad_isoline_coeff_2,
                                                                    self.eta_ad_isoline_coeff_3,
                                                                    self.eta_ad_isoline_coeff_4,
                                                                    self.eta_ad_isoline_coeff_5,
                                                                    self.eta_ad_isoline_coeff_6,
                                                                    self.eta_ad_isoline_coeff_7,
                                                                    self.eta_ad_isoline_coeff_8,
                                                                    self.eta_ad_isoline_coeff_9,
                                                                    self.surgeline_coeff_1, self.surgeline_coeff_2,
                                                                    self.surgeline_coeff_3, self.choke_line_coeff_1,
                                                                    self.choke_line_coeff_2, self.choke_line_coeff_3)
