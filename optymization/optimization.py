from deserialization.network import NetworkDeserialization, networkDeserialization
from deserialization.scenario import Scenario, scenario
from logger.logger import Logger
from optymization.conti_function_approximation import ContiFunction
from optymization.friction_function_approximation import FrictionFunctionApproximation
from optymization.gas_flow_compressor_consumption_approximation import GasFlowCompressorConsumptionApproximation
from optymization.impact_function_approximation import ImpactFunctionApproximation
from optymization.network import Network
from pyscipopt import Model, quicksum
# from gurobipy import *

class Optimization(Network, Logger):
    def __init__(self, networkDescerialization: NetworkDeserialization, scenario: Scenario):
        Network.__init__(self, networkDeserialization, scenario)
        Logger.__init__(self, "optimization.txt")
        self.model = Model("Minimization of Network Flow Operation Costs")
        element_q, node_q, node_p = self.define_model_variables()


        # self.define_model_variables()
        for pipe in networkDeserialization.pipe_list.values():
            m = Model("approximation")
            variable_dict ={}
            pipe.p_e = m.addVar(lb=0.0, ub=0.0, vtype='C')
            conti_functon: ContiFunction = ContiFunction(pipe, m)
            conti_functon._model_definition(pipe, variable_dict)
            m.setObjective(4*variable_dict[pipe.id]+3, "minimize")
            m.optimize()
            # conti_functon._model_definition(pipe, variable_dict)

            # conti: ContiFunction = ContiFunction(pipe, m)
            # print(conti.optimize())
            print("Conti Function Approximation p_min = {}, p_max = {}".format(pipe.from_node.pressure_min, pipe.from_node.pressure_max))
            # friction:FrictionFunctionApproximation = FrictionFunctionApproximation(pipe.from_node.pressure_min, pipe.from_node.pressure_max,
            #                                                                        pipe.from_node.flow_min, pipe.from_node.flow_max,
            #                                                                        pipe, m)
            # print(friction.optimize())
            # print("Friction Function Approximation p_min ={} p_max ={} q_min ={} q_max ={}".format(pipe.from_node.pressure_min, pipe.from_node.pressure_max, pipe.from_node.flow_min, pipe.from_node.flow_max))
            # impact: ImpactFunctionApproximation = ImpactFunctionApproximation(pipe.to_node.pressure_min, pipe.to_node.pressure_max, pipe.to_node.flow_min, pipe.to_node.flow_max, pipe, m)
            # print(impact.optimize())
            # print("ImpactFunctionApproximation p_min ={}, p_max ={} q_min ={}, q_max ={}".format(pipe.to_node.pressure_min, pipe.to_node.pressure_max, pipe.to_node.flow_min, pipe.to_node.flow_max))
            # gas_consumption: GasFlowCompressorConsumptionApproximation = GasFlowCompressorConsumptionApproximation(4000000, 6000000,4000000, 6000000,
            #                                                                                                        1000.0, 1000.0, model=m, compressor=pipe)
            # print(gas_consumption.optimize())
            # print("GasFlowCompressorConsumption  p_min ={}, p_max ={}, p_v_min = {} p_v_max = {} q_min ={}, q_max ={}".format(pipe.from_node.pressure_min, pipe.from_node.pressure_max, pipe.to_node.pressure_min, pipe.to_node.pressure_max, pipe.to_node.flow_min, pipe.to_node.flow_max))
        self.model.optimize()

    def define_model_variables(self):
        element_q, node_q, node_p = {}, {}, {}
        self.define_pipe_variables()
        self.define_valve_variables()
        self.define_short_pipe_variables()
        self.define_resistor_variables()
        self.define_compressor_station_variables()
        self.define_control_valve_variables()
        # self.define_in_node_variables(node_q, node_p, element_q)
        # self.define_source_variables(node_q, node_p, element_q)
        # self.define_sink_variables(node_q, node_p, element_q)
        return element_q, node_q, node_p

    def define_pipe_variables(self):
        for pipe in self.networkDeserialization.pipe_list.values():
            self.f.write("definning variables for pipe with id ={}\n".format(pipe.id))
            pipe.p_b = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id )
            pipe.p_e = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id )
            pipe.q_b = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id )
            pipe.q_e = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id )

    def define_valve_variables(self):
        for pipe in self.networkDeserialization.valve_list.values():
            self.f.write("definning variables for valve with id ={}\n".format(pipe.id))
            pipe.p_b = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.p_e = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.q_b = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)
            pipe.q_e = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)

    def define_short_pipe_variables(self):
        for pipe in self.networkDeserialization.short_pipe_list.values():
            self.f.write("definning variables for pipe with id ={}\n".format(pipe.id))
            pipe.p_b = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.p_e = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.q_b = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)
            pipe.q_e = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)

    def define_resistor_variables(self):
        for pipe in self.networkDeserialization.resistor_list.values():
            self.f.write("definning variables for pipe with id ={}\n".format(pipe.id))
            pipe.p_b = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.p_e = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.q_b = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)
            pipe.q_e = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)

    def define_compressor_station_variables(self):
        for pipe in self.networkDeserialization.compressor_station_list.values():
            self.f.write("definning variables for compressor with id ={}\n".format(pipe.id))
            pipe.p_b = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id )
            pipe.p_e = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id )
            pipe.q_b = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id )
            pipe.q_e = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id )

    def define_control_valve_variables(self):
        for pipe in self.networkDeserialization.control_valve_list.values():
            self.f.write("definning variables for control_valve with id ={}\n".format(pipe.id))
            pipe.p_b = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.p_e = self.model.addVar(lb=pipe.pressure_min, ub=pipe.pressure_max, name="pipe[%s]" % pipe.id)
            pipe.q_b = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)
            pipe.q_e = self.model.addVar(lb=pipe.flow_min, ub=pipe.flow_max, name="pipe[%s]" % pipe.id)

    def define_in_node_variables(self, in_node_q, in_node_p, element_q):
        for in_node in self.networkDeserialization.node_list.values():
            from_pipes =[]
            to_pipes =[]
            # for connection in in_node.from_pipes:


    def define_source_variables(self, source_q, source_p, element_q):
        for source in self.networkDeserialization.source_list.values():
            # source_q[source.id] = self.model.addVar(name="source_q[%s]" % source.id)
            # self.model. addCons(source.flow_in_out == source_q[source.id], "q_source_from[%s]" % source.id)
            self.model. addCons(quicksum(element_q[pipe.id] for pipe in source.from_pipes) == source.flow_in_out,
                               "q_source_to[%s]" % source.id)
            source_p[source.id] = self.model.addVar(lb=source.pressure_lower, ub=source.pressure_upper,
                                                    name="source_p[%s]" % source.id )

    def define_sink_variables(self, sink_q, sink_p, element_q):
        for sink in self.networkDeserialization.sink_list.values():
            # sink_q[sink.id] = self.model.addVar(name="sink_q[%s]" % sink.id)
            self.model. addCons(quicksum(element_q[pipe.id] for pipe in sink.to_pipes) == sink.flow_in_out,
                               "q_sink_from[%s]" % sink.id)
            # self.model. addCons(sink.flow_in_out == sink_q[sink.id], "q_sink_to[%s]" % sink.id)
            sink_p[sink.id] = self.model.addVar(lb=sink.pressure_lower, ub=sink.pressure_upper,
                                                 name="sink_p[%s]" % sink.id )






optimization: Optimization = Optimization(networkDeserialization, scenario)
