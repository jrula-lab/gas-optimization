from typing import Dict

from deserialization.network import NetworkDeserialization
from deserialization.scenario import Scenario


class Network:
    def __init__(self, networkDeserialization: NetworkDeserialization = None, scenario: Scenario = None):
        self.networkDeserialization: NetworkDeserialization = networkDeserialization
        self.scenario: Scenario = scenario
        self.assign_to_from_nodes_to_pipes(self.networkDeserialization.pipe_list)
        self.assign_to_from_nodes_to_pipes(self.networkDeserialization.compressor_station_list)
        self.assign_to_from_nodes_to_pipes(self.networkDeserialization.short_pipe_list)
        self.assign_to_from_nodes_to_pipes(self.networkDeserialization.control_valve_list)
        self.assign_to_from_nodes_to_pipes(self.networkDeserialization.resistor_list)
        self.assign_to_from_nodes_to_pipes(self.networkDeserialization.valve_list)
        self.assign_node_neighbouring_vertexes()
        self.assign_scenario_values_to_sink_source_elements()
        # self.validate_in_nodes()

    def assign_scenario_values_to_sink_source_elements(self):
        for (sink_id, sink) in self.networkDeserialization.sink_list.items():
            for node in self.scenario.scenario_list:
                if node.id == sink_id:
                    sink.assign_values_from_scenario_node(node)

        for (source_id, source) in self.networkDeserialization.source_list.items():
            for node in self.scenario.scenario_list:
                if node.id == source_id:
                    source.assign_values_from_scenario_node(node)
                    if len(source.incoming_vertex) >0:
                        for s in source.incoming_vertex:
                            source.flow_in_out = source.flow_in_out + s.flow_in_out


    def assign_to_from_nodes_to_pipes(self, element_list: Dict):
        for (pipe_id, pipe) in element_list.items():
            if pipe._from in self.networkDeserialization.node_list.keys():
                pipe.from_node = self.networkDeserialization.node_list[pipe._from]
                self.networkDeserialization.node_list[pipe._from].from_pipes.append(pipe)
            elif pipe._from in self.networkDeserialization.source_list.keys():
                pipe.from_node = self.networkDeserialization.source_list[pipe._from]
                self.networkDeserialization.source_list[pipe._from].from_pipes.append(pipe)
            elif pipe._from in self.networkDeserialization.sink_list.keys():
                pipe.from_node = self.networkDeserialization.sink_list[pipe._from]
                self.networkDeserialization.sink_list[pipe._from].from_pipes.append(pipe)

            if pipe.to in self.networkDeserialization.node_list.keys():
                pipe.to_node = self.networkDeserialization.node_list[pipe.to]
                self.networkDeserialization.node_list[pipe.to].to_pipes.append(pipe)
            elif pipe.to in self.networkDeserialization.source_list.keys():
                pipe.to_node = self.networkDeserialization.source_list[pipe.to]
                self.networkDeserialization.source_list[pipe.to].to_pipes.append(pipe)
            elif pipe.to in self.networkDeserialization.sink_list.keys():
                pipe.to_node = self.networkDeserialization.sink_list[pipe.to]
                self.networkDeserialization.sink_list[pipe.to].to_pipes.append(pipe)

    def assign_node_neighbouring_vertexes(self):
        for sink in self.networkDeserialization.sink_list.values():
            sink.assign_neighbouring_vertexes()
        for source in self.networkDeserialization.source_list.values():
            source.assign_neighbouring_vertexes()
        for in_node in self.networkDeserialization.node_list.values():
            in_node.assign_neighbouring_vertexes()

    def validate_in_nodes(self):
        initial_node = list(self.networkDeserialization.source_list.values())[0]
        node_stack = list()
        initial_node.visited = initial_node.attempt_mark_as_visited()
        initial_node.is_on_the_stack = True
        node_stack.append(initial_node)
        while True:
            node = node_stack[-1]
            neighbouring_nodes = node.get_un_visited_vertexes()
            if len(neighbouring_nodes) == 0:
                node.visited = True
                node_stack.pop()
                break
            elif len(neighbouring_nodes) == 1:
                neighbour_node = neighbouring_nodes.pop()
                if node.attempt_mark_as_visited():
                    if node.is_from_node(neighbour_node):
                        neighbour_node.flow_in_out = neighbour_node.flow_in_out + node.flow_in_out
                        neighbour_node.from_flow = neighbour_node.from_flow + node.flow_in_out
                    else:
                        neighbour_node.to_flow = neighbour_node.to_flow + node.flow_in_out
                        neighbour_node.flow_in_out = neighbour_node.flow_in_out + node.flow_in_out
                    node.visited = True
                    node_stack.pop()
                    if not neighbour_node.is_on_the_stack:
                        neighbour_node.is_on_the_stack = True
                        node_stack.append(neighbour_node)
                else:
                    if not neighbour_node.is_on_the_stack:
                        neighbour_node.is_on_the_stack = True
                        node_stack.append(neighbour_node)
            else:

                if (node.from_flow_defined() or node.to_flow_defined()) and node.has_neighbours_on_stack():
                    node_stack.pop()
                    node.is_on_the_stack = False
                    continue
                if node.all_neighbouring_un_visited_vertexes_on_stack():
                    node_stack.pop()
                    node.is_on_the_stack = False
                    continue

                for vertex in neighbouring_nodes:
                    if not vertex.is_on_the_stack and not vertex.visited:
                        vertex.is_on_the_stack = True
                        node_stack.append(vertex)
