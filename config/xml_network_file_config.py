from config.ns import ns
from config.xml_file_config import XMLFileReadingConfig


class XMLNetworkFileLoading(XMLFileReadingConfig):

    @classmethod
    def get_connections_elements(cls, *name):
        connections = cls.open_xml_file(*name)
        return connections.findall('framework:connections', ns)

    @classmethod
    def get_nodes_elements(cls, *name):
        nodes = cls.open_xml_file(*name)
        return nodes.findall('framework:nodes', ns)

    @classmethod
    def get_pipes_list(cls, *name):
        network = cls.get_connections_elements(*name)
        pipe_list = []
        for pipes in network:
            for pipe in pipes.iterfind('gas:pipe', ns):
                print(pipe)
                pipe_list.append(pipe)
        return pipe_list

    @classmethod
    def get_valve_list(cls, *name):
        network = cls.get_connections_elements(*name)
        valve_list = []
        for valves in network:
            for valve in valves.iterfind('gas:valve', ns):
                print(valve)
                valve_list.append(valve)
        return valve_list

    @classmethod
    def get_compressor_station_list(cls, *name):
        network = cls.get_connections_elements(*name)
        compressor_station_list = []
        for compressors in network:
            for compressor in compressors.iterfind('gas:compressorStation', ns):
                print(compressor)
                compressor_station_list.append(compressor)
        return compressor_station_list

    @classmethod
    def get_short_pipe_list(cls, *name):
        network = cls.get_connections_elements(*name)
        short_pipe_list = []
        for short_pipes in network:
            for short_pipe in short_pipes.iterfind('gas:shortPipe', ns):
                print(short_pipe)
                short_pipe_list.append(short_pipe)
        return short_pipe_list

    @classmethod
    def get_resistors_list(cls, *name):
        network = cls.get_connections_elements(*name)
        resistor_list = []
        for resistors in network:
            for resistor in resistors.iterfind('gas:resistor', ns):
                print(resistor)
                resistor_list.append(resistor)
        return resistor_list

    @classmethod
    def get_source_list(cls, *name):
        network = cls.get_nodes_elements(*name)
        source_list = []
        for sources in network:
            for source in sources.iterfind('gas:source', ns):
                print(source)
                source_list.append(source)
        return source_list

    @classmethod
    def get_sink_list(cls, *name):
        network = cls.get_nodes_elements(*name)
        sink_list = []
        for sinks in network:
            for sink in sinks.iterfind('gas:sink', ns):
                print(sink)
                sink_list.append(sink)
        return sink_list

    @classmethod
    def get_innode_list(cls, *name):
        network = cls.get_nodes_elements(*name)
        in_node_list = []
        for in_nodes in network:
            for in_node in in_nodes.iterfind('gas:innode', ns):
                print(in_node)
                in_node_list.append(in_node)
        return in_node_list

    @classmethod
    def get_control_valve_list(cls, *name):
        network = cls.get_connections_elements(*name)
        control_valve_list = []
        for control_valves in network:
            for control_valve in control_valves.iterfind('gas:controlValve', ns):
                print(control_valve)
                control_valve_list.append(control_valve)
        return control_valve_list

    @classmethod
    def get_drive_energy_consumption_measurements(cls, *name):
        network = cls.get_connections_elements(*name)
        energy_consumption = []
        for drive_measurement in network:
            for measurement in drive_measurement.find('gas:drives', ns).find('gas:gasDrivenMotor', ns).find(
                    'gas:specificEnergyConsumptionMeasurements', ns):
                print(measurement)
                energy_consumption.append(measurement)
        return energy_consumption

    @classmethod
    def get_drive_power_measurements(cls, *name):
        network = cls.get_connections_elements(*name)
        power_measurement_list = []
        for power_measurement in network:
            for measurement in power_measurement.find('gas:drives', ns).find('gas:gasDrivenMotor', ns).find(
                    'gas:maximalPowerMeasurements', ns):
                print(measurement)
                power_measurement_list.append(measurement)
        return power_measurement_list
