from deserialization.network import NetworkDeserialization
from deserialization.scenario import Scenario


class Network:
    def __init__(self, networkDeserialization: NetworkDeserialization = None, scenario: Scenario = None):
        self.networkDeserialization: NetworkDeserialization = networkDeserialization
        self.scenario: Scenario = scenario
        self.assign_scenario_values_to_sink_source_elements()
        self.assign_to_from_nodes_to_pipes()

    def assign_scenario_values_to_sink_source_elements(self):
        for (sink_id, sink) in self.networkDeserialization.sink_list.items():
            for node in self.scenario.scenario_list:
                if node.id == sink_id:
                    sink.assign_values_from_scenario_node(node)

        for (source_id, source) in self.networkDeserialization.source_list.items():
            for node in self.scenario.scenario_list:
                if node.id == source_id:
                    source.assign_values_from_scenario_node(node)

    def assign_to_from_nodes_to_pipes(self):
        for (pipe_id, pipe) in self.networkDeserialization.pipe_list.items():
            if pipe._from in self.networkDeserialization.node_list.keys():
                pipe.from_node = self.networkDeserialization.node_list[pipe._from].id
                self.networkDeserialization.node_list[pipe._from].from_pipes.append(pipe_id)
            elif pipe._from in self.networkDeserialization.source_list.keys():
                pipe.from_node = self.networkDeserialization.source_list[pipe._from].id
                self.networkDeserialization.source_list[pipe._from].from_pipes.append(pipe_id)
            elif pipe._from in self.networkDeserialization.sink_list.keys():
                pipe.from_node = self.networkDeserialization.sink_list[pipe._from].id
                self.networkDeserialization.sink_list[pipe._from].from_pipes.append(pipe_id)

            if pipe.to in self.networkDeserialization.node_list.keys():
                pipe.to_node = self.networkDeserialization.node_list[pipe.to].id
                self.networkDeserialization.node_list[pipe.to].to_pipes.append(pipe_id)
            elif pipe.to in self.networkDeserialization.source_list.keys():
                pipe.to_node = self.networkDeserialization.source_list[pipe.to].id
                self.networkDeserialization.source_list[pipe.to].to_pipes.append(pipe_id)
            elif pipe.to in self.networkDeserialization.sink_list.keys():
                pipe.to_node = self.networkDeserialization.sink_list[pipe.to].id
                self.networkDeserialization.sink_list[pipe.to].to_pipes.append(pipe_id)
