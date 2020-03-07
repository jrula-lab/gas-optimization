from config.ns import ns
from config.xml_network_file_config import XMLNetworkFileLoading
from model.network.compressor_station import CompressorStation
from model.network.control_valve import ControlValve
from model.network.innode import Innode
from model.network.node import Node
from model.network.pipe import Pipe
from model.network.resistor import Resistor
from model.network.short_pipe import ShortPipe
from model.network.sink import Sink
from model.network.source import Source
from model.network.valve import Valve


class NetworkDeserialization(XMLNetworkFileLoading):

    @classmethod
    def deserialize_pipe_list(cls, *name) -> [Pipe]:
        pipe_list: [Pipe] = []
        for pipe in cls.get_pipes_list(*name):
            new_pipe = Pipe(pipe.attrib.get('id'), pipe.attrib.get('alias'))
            new_pipe._from = pipe.attrib.get('from')
            new_pipe.to = pipe.attrib.get('to')
            new_pipe.flow_min = cls.get_pipe_flow_min(pipe)
            new_pipe.flow_max = cls.get_pipe_flow_max(pipe)
            new_pipe.length = cls.get_pipe_length(pipe)
            new_pipe.diameter = cls.get_pipe_diameter(pipe)
            new_pipe.roughness = cls.get_pipe_roughness(pipe)
            new_pipe.pressure_max = cls.get_pipe_pressure_max(pipe)
            new_pipe.heat_transfer_coeff = cls.get_pipe_heat_transfer_coefficient(pipe)
            print(new_pipe)
            pipe_list.append(new_pipe)
        return pipe_list

    @classmethod
    def deserialize_valve_list(cls, *name) -> [Valve]:
        valve_list: [Valve] = []
        for valve in cls.get_valve_list(*name):
            new_valve = Valve(valve.attrib.get('id'), valve.attrib.get('alias'))
            new_valve._from = valve.attrib.get('from')
            new_valve.to = valve.attrib.get('to')
            new_valve.flow_min = cls.get_pipe_flow_min(valve)
            new_valve.flow_max = cls.get_pipe_flow_max(valve)
            new_valve.pressure_diff_max = cls.get_valve_pressure_diff_max(valve)
            print(new_valve)
            valve_list.append(new_valve)
        return valve_list

    @classmethod
    def deserialize_short_pipe_list(cls, *name) -> [ShortPipe]:
        short_pipe_list: [ShortPipe] = []
        for short_pipe in cls.get_short_pipe_list(*name):
            new_short_pipe = ShortPipe(short_pipe.attrib.get('id'), short_pipe.attrib.get('alias'))
            new_short_pipe._from = short_pipe.attrib.get('from')
            new_short_pipe.to = short_pipe.attrib.get('to')
            new_short_pipe.flow_min = cls.get_pipe_flow_min(short_pipe)
            new_short_pipe.flow_max = cls.get_pipe_flow_max(short_pipe)
            new_short_pipe.pressure_diff_max = cls.get_valve_pressure_diff_max(short_pipe)
            print(new_short_pipe)
            short_pipe_list.append(new_short_pipe)
        return short_pipe_list

    @classmethod
    def deserialize_resistor_list(cls, *name) -> [Resistor]:
        resistor_list: [Resistor] = []
        for resistor in cls.get_resistors_list(*name):
            new_resistor = Resistor(resistor.attrib.get('id'), resistor.attrib.get('alias'))
            new_resistor._from = resistor.attrib.get('from ')
            new_resistor.to = resistor.attrib.get('to')
            new_resistor.flow_min = cls.get_pipe_flow_min(resistor)
            new_resistor.flow_max = cls.get_pipe_flow_max(resistor)
            new_resistor.diameter = cls.get_pipe_diameter(resistor)
            new_resistor.drag_factor = cls.get_resistor_drag_factor(resistor)
            print(new_resistor)
            resistor_list.append(new_resistor)
        return resistor_list

    @classmethod
    def deserialize_compressor_station_list(cls, *name) -> [CompressorStation]:
        compressor_station_list: [CompressorStation] = []
        for compressor in cls.get_compressor_station_list(*name):
            new_compressor = CompressorStation(compressor.attrib.get('id'), compressor.attrib.get('alias'))
            new_compressor._from = compressor.attrib.get('from')
            new_compressor.to = compressor.attrib.get('to')
            new_compressor.flow_min = cls.get_pipe_flow_min(compressor)
            new_compressor.flow_max = cls.get_pipe_flow_max(compressor)
            new_compressor.pressure_in_min = cls.get_compressor_pressure_in_min(compressor)
            new_compressor.pressure_out_max = cls.get_compressor_pressure_out_max(compressor)
            print(new_compressor)
            compressor_station_list.append(new_compressor)
        return compressor_station_list

    @classmethod
    def deserialize_node(cls, new_source, source):
        new_source._from = source.attrib.get('from')
        new_source.to = source.attrib.get('to')
        new_source.geo_lat = cls.get_node_geo_lat(source)
        new_source.geo_long = cls.get_node_geo_long(source)
        new_source.x = cls.get_node_x(source)
        new_source.y = cls.get_node_y(source)
        new_source.height = cls.get_node_height(source)
        new_source.pressure_min = cls.get_node_pressure_min(source)
        new_source.pressure_max = cls.get_node_pressure_max(source)

    @classmethod
    def deserialize_source_list(cls, *name) -> [Source]:
        source_list: [Source] = []
        for source in cls.get_source_list(*name):
            new_source = Source(source.attrib.get('id'), source.attrib.get('alias'))
            cls.serialize_node(new_source, source)
            new_source.flow_min = cls.get_pipe_flow_min(source)
            new_source.flow_max = cls.get_pipe_flow_max(source)
            new_source.gas_temperature = cls.get_source_gas_temperature(source)
            new_source.calorific_value = cls.get_source_calorific_value(source)
            new_source.norm_density = cls.get_source_norm_density(source)
            new_source.coeff_a_heat_capacity = cls.get_source_coefficient_a_heat_capacity(source)
            new_source.coeff_b_heat_capacity = cls.get_source_coefficient_b_heat_capacity(source)
            new_source.coeff_c_heat_capacity = cls.get_source_coefficient_c_heat_capacity(source)
            new_source.molar_mass = cls.get_source_moral_mass(source)
            new_source.pseudo_critical_pressure = cls.get_source_pseudo_critical_pressure(source)
            new_source.pseudo_critical_temperature = cls.get_source_pseudo_critical_temperature(source)
            print(new_source)
            source_list.append(new_source)
        return source_list

    @classmethod
    def deserialize_sink_list(cls, *name) -> [Sink]:
        sink_list: [Sink] = []
        for sink in cls.get_sink_list(*name):
            new_sink = Sink(sink.attrib.get('id'), sink.attrib.get('alias'))
            cls.serialize_node(new_sink, sink)
            new_sink.flow_max = cls.get_pipe_flow_max(sink)
            new_sink.flow_min = cls.get_pipe_flow_min(sink)
            print(new_sink)
            sink_list.append(new_sink)
        return sink_list

    @classmethod
    def deserialize_innode_list(cls, *name) -> [Innode]:
        innode_list: [Innode] = []
        for innode in cls.get_innode_list(*name):
            new_innode = Innode(innode.attrib.get('id'), innode.attrib.get('alias'))
            cls.serialize_node(new_innode, innode)
            print(new_innode)
            innode_list.append(new_innode)
        return innode_list

    @classmethod
    def deserialize_control_valve_list(cls, *name) -> [ControlValve]:
        control_valve_list: [ControlValve] = []
        for control_valve in cls.get_control_valve_list(*name):
            new_control_valve = ControlValve(control_valve.attrib.get('id'), control_valve.attrib.get('alias'))
            new_control_valve._from = control_valve.attrib.get('from')
            new_control_valve.to = control_valve.attrib.get('to')
            new_control_valve.flow_min = cls.get_pipe_flow_min(control_valve)
            new_control_valve.flow_max = cls.get_pipe_flow_max(control_valve)
            new_control_valve.pressure_out_max = cls.get_control_valve_pressure_out_max(control_valve)
            new_control_valve.pressure_in_min = cls.get_control_valve_pressure_in_min(control_valve)
            new_control_valve.pressure_loss_in = cls.get_control_valve_pressure_loss_in(control_valve)
            new_control_valve.pressure_loss_out = cls.get_control_valve_pressure_loss_out(control_valve)
            new_control_valve.pressure_diff_min = cls.get_control_valve_pressure_diff_min(control_valve)
            new_control_valve.pressure_diff_max = cls.get_valve_pressure_diff_max(control_valve)
            control_valve_list.append(new_control_valve)
            print(new_control_valve)
        return control_valve_list

    @classmethod
    def get_pipe_flow_min(cls, pipe):
        return float(pipe.find('gas:flowMin', ns).attrib.get('value'))

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
        return float(pipe.find('gas:pressureMax', ns).attrib.get('value'))

    @classmethod
    def get_pipe_heat_transfer_coefficient(cls, pipe):
        return float(pipe.find('gas:heatTransferCoefficient', ns).attrib.get('value'))

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


# NetworkDeserialization.get_innode_list('data', 'GasLib-11', 'GasLib-11.net')
NetworkDeserialization.deserialize_control_valve_list('data', 'GasLib-582', 'GasLib-582.net')
