from config.ns import ns
from config.xml_compressor_station_file_config import XMLCompressorStationFileLoading
from model.compressor_station.compressor_station import CompressorStation
from model.compressor_station.configuration import Configuration
from model.compressor_station.gas_turbine import GasTurbine
from model.compressor_station.turbo_compressor import TurboCompressor


class CompressorStationDeserialization(XMLCompressorStationFileLoading):

    @classmethod
    def deserialize_compressor_station(cls, *name):
        compressor_station_list:[CompressorStation] = []
        for compressor_station in cls.get_compressor_station_list(*name):
            new_compressor_station = CompressorStation(compressor_station['id'])
            new_compressor_station.drivers = cls.deserialize_gas_turbine_list(compressor_station['gas_turbine'])
            new_compressor_station.compressors = cls.deserialize_turbo_compressor_list(compressor_station['turbo_compressor'])
            new_compressor_station.configurations = cls.deserialize_configuration_list(compressor_station['configuration'])
            compressor_station_list.append(new_compressor_station)
            print(new_compressor_station)
        return compressor_station_list

    @classmethod
    def deserialize_gas_turbine_list(cls, element) ->[GasTurbine]:
        gas_turbine_list: [GasTurbine] = []
        for gas_turbine in element:
            new_gas_turbine = GasTurbine(gas_turbine.attrib.get('id'))
            new_gas_turbine.energy_rate_fun_coeff_1 = cls.get_gas_turbine_energy_rate_fun_coeff_1(gas_turbine)
            new_gas_turbine.energy_rate_fun_coeff_2 = cls.get_gas_trubine_energy_rate_fun_coeff_2(gas_turbine)
            new_gas_turbine.energy_rate_fun_coeff_3 = cls.get_gas_trubine_energy_rate_fun_coeff_3(gas_turbine)
            new_gas_turbine.power_fun_coeff_1 = cls.get_gas_trubine_power_fun_coeff_1(gas_turbine)
            new_gas_turbine.power_fun_coeff_2 = cls.get_gas_trubine_power_fun_coeff_2(gas_turbine)
            new_gas_turbine.power_fun_coeff_3 = cls.get_gas_trubine_power_fun_coeff_3(gas_turbine)
            new_gas_turbine.power_fun_coeff_4 = cls.get_gas_trubine_power_fun_coeff_4(gas_turbine)
            new_gas_turbine.power_fun_coeff_5 = cls.get_gas_trubine_power_fun_coeff_5(gas_turbine)
            new_gas_turbine.power_fun_coeff_6 = cls.get_gas_trubine_power_fun_coeff_6(gas_turbine)
            new_gas_turbine.power_fun_coeff_7 = cls.get_gas_trubine_power_fun_coeff_7(gas_turbine)
            new_gas_turbine.power_fun_coeff_8 = cls.get_gas_trubine_power_fun_coeff_8(gas_turbine)
            new_gas_turbine.power_fun_coeff_9 = cls.get_gas_trubine_power_fun_coeff_9(gas_turbine)
            print(new_gas_turbine)
            gas_turbine_list.append(new_gas_turbine)
        return gas_turbine_list

    @classmethod
    def deserialize_configuration_list(cls, element) ->[Configuration]:
        configuration_list: [Configuration] = []
        for configuration in element:
            new_configuration = Configuration(configuration.attrib.get('conf_id'),
                                              configuration.attrib.get('nrOfSerialStages'))
            new_configuration.stage_nr = float(cls.get_configuration_stage(configuration).attrib.get('stageNr'))
            new_configuration.nr_of_parallel_units = float(
                cls.get_configuration_stage(configuration).attrib.get('nrOfParallelUnits'))
            new_configuration.compressor_id = cls.get_configuration_stage_compressor(configuration).attrib.get('id')
            new_configuration.nominal_speed = float(
                cls.get_configuration_stage_compressor(configuration).attrib.get('nominalSpeed'))
            print(new_configuration)
            configuration_list.append(new_configuration)
        return configuration_list

    @classmethod
    def deserialize_turbo_compressor_list(cls, element) ->[TurboCompressor]:
        turbo_compressor_list: [TurboCompressor] = []
        for turbo_compressor in element:
            new_turbo_compressor = TurboCompressor(turbo_compressor.attrib.get('id'))
            new_turbo_compressor.speed_min = cls.get_turbo_compressor_speed_min(turbo_compressor)
            new_turbo_compressor.speed_max = cls.get_turbo_compressor_speed_max(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_1 = cls.get_turbo_compressor_n_isoline_coeff_1(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_2 = cls.get_turbo_compressor_n_isoline_coeff_2(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_3 = cls.get_turbo_compressor_n_isoline_coeff_3(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_4 = cls.get_turbo_compressor_n_isoline_coeff_4(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_5 = cls.get_turbo_compressor_n_isoline_coeff_5(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_6 = cls.get_turbo_compressor_n_isoline_coeff_6(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_7 = cls.get_turbo_compressor_n_isoline_coeff_7(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_8 = cls.get_turbo_compressor_n_isoline_coeff_8(turbo_compressor)
            new_turbo_compressor.n_isoline_coeff_9 = cls.get_turbo_compressor_n_isoline_coeff_9(turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_1 = cls.get_turbo_compressor_eta_ad_isoline_coeff_1(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_2 = cls.get_turbo_compressor_eta_ad_isoline_coeff_2(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_3 = cls.get_turbo_compressor_eta_ad_isoline_coeff_3(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_4 = cls.get_turbo_compressor_eta_ad_isoline_coeff_4(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_5 = cls.get_turbo_compressor_eta_ad_isoline_coeff_5(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_6 = cls.get_turbo_compressor_eta_ad_isoline_coeff_6(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_7 = cls.get_turbo_compressor_eta_ad_isoline_coeff_7(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_8 = cls.get_turbo_compressor_eta_ad_isoline_coeff_8(
                turbo_compressor)
            new_turbo_compressor.eta_ad_isoline_coeff_9 = cls.get_turbo_compressor_eta_ad_isoline_coeff_9(
                turbo_compressor)
            new_turbo_compressor.surgeline_coeff_1 = cls.get_turbo_compressor_surgeline_coeff_1(turbo_compressor)
            new_turbo_compressor.surgeline_coeff_2 = cls.get_turbo_compressor_surgeline_coeff_2(turbo_compressor)
            new_turbo_compressor.surgeline_coeff_3 = cls.get_turbo_compressor_surgeline_coeff_3(turbo_compressor)
            new_turbo_compressor.choke_line_coeff_1 = cls.get_turbo_compressor_chokeline_coeff_1(turbo_compressor)
            new_turbo_compressor.choke_line_coeff_2 = cls.get_turbo_compressor_chokeline_coeff_2(turbo_compressor)
            new_turbo_compressor.choke_line_coeff_3 = cls.get_turbo_compressor_chokeline_coeff_3(turbo_compressor)
            print(new_turbo_compressor)
            turbo_compressor_list.append(new_turbo_compressor)
        return turbo_compressor_list

    @classmethod
    def get_gas_turbine_energy_rate_fun_coeff_1(cls, gas_turbine):
        aaa = gas_turbine.find('compressor_stations:energy_rate_fun_coeff_1', ns)
        return float(gas_turbine.find('compressor_stations:energy_rate_fun_coeff_1', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_energy_rate_fun_coeff_2(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:energy_rate_fun_coeff_2', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_energy_rate_fun_coeff_3(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:energy_rate_fun_coeff_3', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_1(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_1', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_2(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_2', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_3(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_3', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_4(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_4', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_5(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_5', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_6(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_6', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_7(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_7', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_8(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_8', ns).attrib.get('value'))

    @classmethod
    def get_gas_trubine_power_fun_coeff_9(cls, gas_turbine):
        return float(gas_turbine.find('compressor_stations:power_fun_coeff_9', ns).attrib.get('value'))

    @classmethod
    def get_configuration_stage(cls, configuration):
        return configuration.find('compressor_stations:stage', ns)

    @classmethod
    def get_configuration_stage_compressor(cls, configuration):
        return cls.get_configuration_stage(configuration).find('compressor_stations:compressor', ns)

    @classmethod
    def get_turbo_compressor_speed_min(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:speedMin', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_speed_max(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:speedMax', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_1(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_1', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_2(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_2', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_3(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_3', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_4(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_4', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_5(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_5', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_6(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_6', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_7(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_7', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_8(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_8', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_n_isoline_coeff_9(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:n_isoline_coeff_9', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_1(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_1', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_2(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_2', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_3(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_3', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_4(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_4', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_5(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_5', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_6(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_6', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_7(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_7', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_8(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_8', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_eta_ad_isoline_coeff_9(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:eta_ad_isoline_coeff_9', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_surgeline_coeff_1(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:surgeline_coeff_1', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_surgeline_coeff_2(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:surgeline_coeff_2', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_surgeline_coeff_3(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:surgeline_coeff_3', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_chokeline_coeff_1(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:chokeline_coeff_1', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_chokeline_coeff_2(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:chokeline_coeff_2', ns).attrib.get('value'))

    @classmethod
    def get_turbo_compressor_chokeline_coeff_3(cls, turbo_compressor):
        return float(turbo_compressor.find('compressor_stations:chokeline_coeff_3', ns).attrib.get('value'))


CompressorStationDeserialization.deserialize_compressor_station('data', 'GasLib-582', 'GasLib-582.cs')