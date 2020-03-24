from deserialization.network import NetworkDeserialization, networkDeserialization
from deserialization.scenario import Scenario, scenario
from optymization.network import Network
from pyscipopt import Model, quicksum


class Optimization(Network):

    def __init__(self, networkDescerialization: NetworkDeserialization, scenario: Scenario):
        Network.__init__(self, networkDeserialization, scenario)
        self.model = Model("Minimization of Network Flow Operation Costs")

    def assign_pipe_values_to_node_elements(self):
        for sink in self.networkDeserialization.sink_list:
            from_value: float = 0.0
            for pipe in self.networkDeserialization.pipe_list:
                if pipe._from == sink.id:
                    pass



optimization: Optimization = Optimization(networkDeserialization, scenario)