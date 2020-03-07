from config.ns import ns
from config.xml_file_config import XMLFileReadingConfig


class XMLCompressorStationFileLoading(XMLFileReadingConfig):

    @classmethod
    def get_compressor_stations(cls, *name):
        connections = cls.open_xml_file(*name)
        return connections.findall('compressor_stations:compressorStation', ns)

    @classmethod
    def get_compressor_station_list(cls, *name):
        compressor_station_list = []
        for compressor_station in cls.get_compressor_stations(*name):
            station = {}
            station['id'] = compressor_station.attrib.get('id')
            station['turbo_compressor'] = cls.get_turbo_compressor_list(compressor_station)
            station['configuration'] = cls.get_configuration_list(compressor_station)
            station['gas_turbine'] = cls.get_gas_turbine_list(compressor_station)
            print(station)
            compressor_station_list.append(station)
        return compressor_station_list

    @classmethod
    def get_turbo_compressor_list(cls, element):
        turbo_compressor_list = []
        for compressors in element.iterfind('compressor_stations:compressors', ns):
            for turbo_compressor in compressors.iterfind('compressor_stations:turboCompressor', ns):
                print(turbo_compressor)
                turbo_compressor_list.append(turbo_compressor)
        return turbo_compressor_list

    @classmethod
    def get_configuration_list(cls, element):
        configuration_list = []
        for configurations in element.iterfind('compressor_stations:configurations', ns):
            for configuration in configurations.iterfind('compressor_stations:configuration', ns):
                print(configuration)
                configuration_list.append(configuration)
        return configuration_list

    @classmethod
    def get_gas_turbine_list(cls, element):
        gas_turbine_list = []
        for drives in element.iterfind('compressor_stations:drives', ns):
            for gas_turbine in drives.iterfind('compressor_stations:gasTurbine', ns):
                print(gas_turbine)
                gas_turbine_list.append(gas_turbine)
        return gas_turbine_list


# print(XMLCompressorStationFileLoading.get_compressor_stations('data', 'GasLib-582', 'GasLib-582.cs'))
