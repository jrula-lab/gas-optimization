from typing import Tuple

from config.ns import ns
from config.xml_network_file_config import XMLNetworkFileLoading
from constants_global.constants import network_file
from logger.logger import Logger
from model.network.compressor_station import CompressorStation
from model.network.control_valve import ControlValve
from model.network.innode import Innode
from model.network.pipe import Pipe
from model.network.resistor import Resistor
from model.network.short_pipe import ShortPipe
from model.network.sink import Sink
from model.network.source import Source
from model.network.valve import Valve


class NetworkDeserialization(XMLNetworkFileLoading, Logger):

    def __init__(self, *filename, file_name: str = "networkDeserialization.txt"):
        Logger.__init__(self, file_name)
        self.f.write("Network Deserialization Data")
        self.pipe_list: {Pipe} = self.deserialize_pipe_list(*filename)
        self.valve_list: {Valve} = self.deserialize_valve_list(*filename)
        self.short_pipe_list: {ShortPipe} = self.deserialize_short_pipe_list(*filename)
        self.resistor_list: {Resistor} = self.deserialize_resistor_list(*filename)
        self.compressor_station_list: {CompressorStation} = self.deserialize_compressor_station_list(*filename)
        self.node_list: {Innode} = self.deserialize_innode_list(*filename)
        self.source_list: {Source} = self.deserialize_source_list(*filename)
        self.sink_list: {Sink} = self.deserialize_sink_list(*filename)
        self.control_valve_list: {ControlValve} = self.deserialize_control_valve_list(*filename)
        self.energy_consumption_measurement = self.deserialize_energy_consumption_measurement(*filename)
        self.power_measurement = self.deserialize_power_measurement(*filename)
        CompressorStation.set_energy_power_measurement(self.energy_consumption_measurement, self.power_measurement)
        Source.read_constant_data(self.source_list)
        self.f.close()

    def deserialize_pipe_list(cls, *name) -> {Pipe}:
        pipe_list: {Pipe} = {}
        for pipe in cls.get_pipes_list(*name):
            new_pipe = Pipe(pipe.attrib.get('id'), pipe.attrib.get('alias'))
            new_pipe._from = pipe.attrib.get('from')
            new_pipe.to = pipe.attrib.get('to')
            new_pipe.flow_min = cls.get_pipe_flow_min(pipe)
            new_pipe.flow_max = cls.get_pipe_flow_max(pipe)
            new_pipe.length = cls.get_pipe_length(pipe)*10**3
            new_pipe.diameter = cls.get_pipe_diameter(pipe)*10**(-3)
            new_pipe.roughness = cls.get_pipe_roughness(pipe)
            new_pipe.pressure_max = cls.get_pipe_pressure_max(pipe)*10**5
            new_pipe.heat_transfer_coeff = cls.get_pipe_heat_transfer_coefficient(pipe)*10**5
            new_pipe.calculate_friction_factor()
            print(new_pipe)
            cls.f.write(new_pipe.__str__())
            pipe_list[new_pipe.id] = new_pipe
        return pipe_list

    def deserialize_valve_list(cls, *name) -> {Valve}:
        valve_list: {Valve} = {}
        for valve in cls.get_valve_list(*name):
            new_valve = Valve(valve.attrib.get('id'), valve.attrib.get('alias'))
            new_valve._from = valve.attrib.get('from')
            new_valve.to = valve.attrib.get('to')
            new_valve.flow_min = cls.get_pipe_flow_min(valve)
            new_valve.flow_max = cls.get_pipe_flow_max(valve)
            new_valve.pressure_diff_max = cls.get_valve_pressure_diff_max(valve)*10**5
            print(new_valve)
            cls.f.write(new_valve.__str__())
            valve_list[new_valve.id] = new_valve
        return valve_list

    def deserialize_short_pipe_list(cls, *name) -> {ShortPipe}:
        short_pipe_list: {ShortPipe} = {}
        for short_pipe in cls.get_short_pipe_list(*name):
            new_short_pipe = ShortPipe(short_pipe.attrib.get('id'), short_pipe.attrib.get('alias'))
            new_short_pipe._from = short_pipe.attrib.get('from')
            new_short_pipe.to = short_pipe.attrib.get('to')
            new_short_pipe.flow_min = cls.get_pipe_flow_min(short_pipe)
            new_short_pipe.flow_max = cls.get_pipe_flow_max(short_pipe)
            new_short_pipe.pressure_max = cls.get_pipe_pressure_max(short_pipe)*10**5
            print(new_short_pipe)
            cls.f.write(new_short_pipe.__str__())
            short_pipe_list[new_short_pipe.id] = new_short_pipe
        return short_pipe_list

    def deserialize_resistor_list(cls, *name) -> {Resistor}:
        resistor_list: {Resistor} = {}
        for resistor in cls.get_resistors_list(*name):
            new_resistor = Resistor(resistor.attrib.get('id'), resistor.attrib.get('alias'))
            new_resistor._from = resistor.attrib.get('from ')
            new_resistor.to = resistor.attrib.get('to')
            new_resistor.flow_min = cls.get_pipe_flow_min(resistor)
            new_resistor.flow_max = cls.get_pipe_flow_max(resistor)
            new_resistor.diameter = cls.get_pipe_diameter(resistor)/10**(-3)
            new_resistor.drag_factor = cls.get_resistor_drag_factor(resistor)
            print(new_resistor)
            cls.f.write(new_resistor.__str__())
            resistor_list[new_resistor.id] = new_resistor
        return resistor_list

    def deserialize_compressor_station_list(cls, *name) -> {CompressorStation}:
        compressor_station_list: {CompressorStation} = {}
        for compressor in cls.get_compressor_station_list(*name):
            new_compressor = CompressorStation(compressor.attrib.get('id'), compressor.attrib.get('alias'))
            new_compressor._from = compressor.attrib.get('from')
            new_compressor.to = compressor.attrib.get('to')
            new_compressor.flow_min = cls.get_pipe_flow_min(compressor)
            new_compressor.flow_max = cls.get_pipe_flow_max(compressor)
            new_compressor.pressure_in_min = cls.get_compressor_pressure_in_min(compressor)*10**5
            new_compressor.pressure_out_max = cls.get_compressor_pressure_out_max(compressor)*10**5
            new_compressor.pressure_max = cls.get_pipe_pressure_max(compressor)*10**5
            print(new_compressor)
            cls.f.write(new_compressor.__str__())
            compressor_station_list[new_compressor.id] = new_compressor
        return compressor_station_list

    def deserialize_node(cls, new_source, source):
        new_source._from = source.attrib.get('from')
        new_source.to = source.attrib.get('to')
        new_source.geo_lat = cls.get_node_geo_lat(source)
        new_source.geo_long = cls.get_node_geo_long(source)
        new_source.x = cls.get_node_x(source)
        new_source.y = cls.get_node_y(source)
        new_source.height = cls.get_node_height(source)
        new_source.pressure_min = cls.get_node_pressure_min(source)*10**5
        new_source.pressure_max = cls.get_node_pressure_max(source)*10**5

    def deserialize_source_list(cls, *name) -> {Source}:
        source_list: {Source} = {}
        for source in cls.get_source_list(*name):
            new_source = Source(source.attrib.get('id'), source.attrib.get('alias'))
            cls.deserialize_node(new_source, source)
            new_source.flow_min = cls.get_pipe_flow_min(source)
            new_source.flow_max = cls.get_pipe_flow_max(source)
            new_source.gas_temperature = cls.get_source_gas_temperature(source)
            new_source.calorific_value = cls.get_source_calorific_value(source)*10**6
            new_source.norm_density = cls.get_source_norm_density(source)
            new_source.coeff_a_heat_capacity = cls.get_source_coefficient_a_heat_capacity(source)/10**3
            new_source.coeff_b_heat_capacity = cls.get_source_coefficient_b_heat_capacity(source)/10**3
            new_source.coeff_c_heat_capacity = cls.get_source_coefficient_c_heat_capacity(source)/10**3
            new_source.molar_mass = cls.get_source_moral_mass(source)
            new_source.pseudo_critical_pressure = cls.get_source_pseudo_critical_pressure(source)*10**5
            new_source.pseudo_critical_temperature = cls.get_source_pseudo_critical_temperature(source)
            print(new_source)
            cls.f.write(new_source.__str__())
            source_list[new_source.id] = new_source
        return source_list

    def deserialize_sink_list(cls, *name) -> {Sink}:
        sink_list: {Sink} = {}
        for sink in cls.get_sink_list(*name):
            new_sink = Sink(sink.attrib.get('id'), sink.attrib.get('alias'))
            cls.deserialize_node(new_sink, sink)
            new_sink.flow_max = cls.get_pipe_flow_max(sink)
            new_sink.flow_min = cls.get_pipe_flow_min(sink)
            print(new_sink)
            cls.f.write(new_sink.__str__())
            sink_list[new_sink.id] = new_sink
        return sink_list

    def deserialize_innode_list(cls, *name) -> {Innode}:
        innode_list: {Innode} = {}
        for innode in cls.get_innode_list(*name):
            new_innode = Innode(innode.attrib.get('id'), innode.attrib.get('alias'))
            cls.deserialize_node(new_innode, innode)
            print(new_innode)
            cls.f.write(new_innode.__str__())
            innode_list[new_innode.id] = new_innode
        return innode_list

    def deserialize_control_valve_list(cls, *name) -> {ControlValve}:
        control_valve_list: {ControlValve} = {}
        for control_valve in cls.get_control_valve_list(*name):
            new_control_valve = ControlValve(control_valve.attrib.get('id'), control_valve.attrib.get('alias'))
            new_control_valve._from = control_valve.attrib.get('from')
            new_control_valve.to = control_valve.attrib.get('to')
            new_control_valve.flow_min = cls.get_pipe_flow_min(control_valve)
            new_control_valve.flow_max = cls.get_pipe_flow_max(control_valve)
            new_control_valve.pressure_out_max = cls.get_control_valve_pressure_out_max(control_valve)*10**5
            new_control_valve.pressure_in_min = cls.get_control_valve_pressure_in_min(control_valve)*10**5
            new_control_valve.pressure_loss_in = cls.get_control_valve_pressure_loss_in(control_valve)*10**5
            new_control_valve.pressure_loss_out = cls.get_control_valve_pressure_loss_out(control_valve)*10**5
            new_control_valve.pressure_diff_min = cls.get_control_valve_pressure_diff_min(control_valve)*10**5
            new_control_valve.pressure_diff_max = cls.get_valve_pressure_diff_max(control_valve)*10**5
            control_valve_list[new_control_valve.id] = new_control_valve
            print(new_control_valve)
            cls.f.write(new_control_valve.__str__())
        return control_valve_list

    def deserialize_energy_consumption_measurement(cls, *name) -> [Tuple]:
        energy_consumption_measurement: [Tuple] = []
        for energy_consumption in cls.get_drive_energy_consumption_measurements(*name):
            measurement = tuple([cls.get_drive_energy_consumption_compressor_power(energy_consumption)*10**3,
                                 cls.get_drive_energy_consumption_fuel_consumption(energy_consumption)*10**3])
            print(measurement)
            cls.f.write(measurement.__str__())
            energy_consumption_measurement.append(measurement)
        energy_consumption_measurement.append(tuple([0.0, 0.0]))
        return energy_consumption_measurement

    def deserialize_power_measurement(cls, *name) -> [Tuple]:
        power_measurement: [Tuple] = []
        for power in cls.get_drive_power_measurements(*name):
            measurement = tuple([cls.get_drive_power_speed(power)*10**3, cls.get_drive_maximal_power(power)*10**3])
            print(measurement)
            cls.f.write(measurement.__str__())
            power_measurement.append(measurement)
        return power_measurement

    @classmethod
    def get_pipe_flow_min(cls, pipe):
        pip = float(pipe.find('gas:flowMin', ns).attrib.get('value'))
        return pip if pip > 0.0 else 0.0

    @classmethod
    def get_pipe_flow_max(cls, pipe):
        return float(pipe.find('gas:flowMax', ns).attrib.get('value'))

    @classmethod
    def get_pipe_length(cls, pipe):
        return float(pipe.find('gas:length', ns).attrib.get('value'))

    @classmethod
    def get_pipe_diameter(cls, pipe):
        return float(pipe.find('gas:diameter', ns).attrib.get('value'))

    @classmethod
    def get_pipe_roughness(cls, pipe):
        return float(pipe.find('gas:roughness', ns).attrib.get('value'))

    @classmethod
    def get_pipe_pressure_max(cls, pipe):
        pip = pipe.find('gas:pressureMax', ns)
        return float(pip.attrib.get('value')) if pip is not None else 0.0

    @classmethod
    def get_pipe_heat_transfer_coefficient(cls, pipe):
        pip = pipe.find('gas:heatTransferCoefficient', ns)
        return float(pip.attrib.get('value')) if pip else 0.0

    @classmethod
    def get_valve_pressure_diff_max(cls, valve):
        return float(valve.find('gas:pressureDifferentialMax', ns).attrib.get('value'))

    @classmethod
    def get_resistor_drag_factor(cls, resistor):
        return float(resistor.find('gas:dragFactor', ns).attrib.get('value'))

    @classmethod
    def get_compressor_drag_fraction_in(cls, compressor):
        return float(compressor.find('gas:dragFactorIn', ns).attrib.get('value'))

    @classmethod
    def get_compressor_diameter_in(cls, compressor):
        return float(compressor.find('gas:diameterIn', ns).attrib.get('value'))

    @classmethod
    def get_compressor_drag_factor_out(cls, compressor):
        return float(compressor.find('gas:dragFactorOut', ns).attrib.get('value'))

    @classmethod
    def get_compressor_diameter_out(cls, compressor):
        return float(compressor.find('gas:diameterOut', ns).attrib.get('value'))

    @classmethod
    def get_compressor_pressure_in_min(cls, compressor):
        return float(compressor.find('gas:pressureInMin', ns).attrib.get('value'))

    @classmethod
    def get_compressor_pressure_out_max(cls, compressor):
        return float(compressor.find('gas:pressureOutMax', ns).attrib.get('value'))

    @classmethod
    def get_node_height(cls, node):
        return float(node.find('gas:height', ns).attrib.get('value'))

    @classmethod
    def get_node_pressure_min(cls, node):
        return float(node.find('gas:pressureMin', ns).attrib.get('value'))

    @classmethod
    def get_node_pressure_max(cls, node):
        return float(node.find('gas:pressureMax', ns).attrib.get('value'))

    @classmethod
    def get_source_gas_temperature(cls, source):
        return float(source.find('gas:gasTemperature', ns).attrib.get('value'))

    @classmethod
    def get_source_calorific_value(cls, source):
        return float(source.find('gas:calorificValue', ns).attrib.get('value'))

    @classmethod
    def get_source_norm_density(cls, source):
        return float(source.find('gas:normDensity', ns).attrib.get('value'))

    @classmethod
    def get_source_coefficient_a_heat_capacity(cls, source):
        return float(source.find('gas:coefficient-A-heatCapacity', ns).attrib.get('value'))

    @classmethod
    def get_source_coefficient_b_heat_capacity(cls, source):
        return float(source.find('gas:coefficient-B-heatCapacity', ns).attrib.get('value'))

    @classmethod
    def get_source_coefficient_c_heat_capacity(cls, source):
        return float(source.find('gas:coefficient-C-heatCapacity', ns).attrib.get('value'))

    @classmethod
    def get_source_moral_mass(cls, source):
        return float(source.find('gas:molarMass', ns).attrib.get('value'))

    @classmethod
    def get_source_pseudo_critical_pressure(cls, source):
        return float(source.find('gas:pseudocriticalPressure', ns).attrib.get('value'))

    @classmethod
    def get_source_pseudo_critical_temperature(cls, source):
        return float(source.find('gas:pseudocriticalTemperature', ns).attrib.get('value'))

    @classmethod
    def get_node_geo_lat(cls, node):
        lat = node.attrib.get('geoWGS84Lat')
        return float(lat if lat is not None else 0)

    @classmethod
    def get_node_geo_long(cls, node):
        long = node.attrib.get('geoWGS84Long')
        return float(long if long is not None else 0)

    @classmethod
    def get_node_x(cls, node):
        return float(node.attrib.get('x'))

    @classmethod
    def get_node_y(cls, node):
        return float(node.attrib.get('y'))

    @classmethod
    def get_control_valve_pressure_diff_min(cls, control_valve):
        return float(control_valve.find('gas:pressureDifferentialMin', ns).attrib.get('value'))

    @classmethod
    def get_control_valve_pressure_diff_max(cls, control_valve):
        return float(control_valve.find('gas:pressureDifferentialMax', ns).attrib.get('value'))

    @classmethod
    def get_control_valve_pressure_loss_in(cls, control_valve):
        return float(control_valve.find('gas:pressureLossIn', ns).attrib.get('value'))

    @classmethod
    def get_control_valve_pressure_loss_out(cls, control_valve):
        return float(control_valve.find('gas:pressureLossOut', ns).attrib.get('value'))

    @classmethod
    def get_control_valve_pressure_out_max(cls, control_valve):
        return float(control_valve.find('gas:pressureOutMax', ns).attrib.get('value'))

    @classmethod
    def get_control_valve_pressure_in_min(cls, control_valve):
        return float(control_valve.find('gas:pressureInMin', ns).attrib.get('value'))

    @classmethod
    def get_drive_energy_consumption_compressor_power(cls, energy_consumption):
        return float(energy_consumption.find('gas:compressorPower', ns).attrib.get('value'))

    @classmethod
    def get_drive_energy_consumption_fuel_consumption(cls, fuel_consumption):
        return float(fuel_consumption.find('gas:fuelConsumption', ns).attrib.get('value'))

    @classmethod
    def get_drive_power_speed(cls, speed):
        return float(speed.find('gas:speed', ns).attrib.get('value'))

    @classmethod
    def get_drive_maximal_power(cls, power):
        return float(power.find('gas:maximalPower', ns).attrib.get('value'))


networkDeserialization: NetworkDeserialization = NetworkDeserialization(*network_file)
