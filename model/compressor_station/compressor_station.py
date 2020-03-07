from model.compressor_station.configuration import Configuration
from model.compressor_station.gas_turbine import GasTurbine
from model.compressor_station.turbo_compressor import TurboCompressor


class CompressorStation:

    def __init__(self, id):
        self.id = id
        self.compressors: [TurboCompressor] = []
        self.drivers: [GasTurbine] = []
        self.configurations: [Configuration] =[]
