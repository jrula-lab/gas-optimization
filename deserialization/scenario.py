from config.ns import ns
from config.xml_scenario_file_config import XMLScenarioFileLoading
from model.scenario.scenario_node import ScenarioNode


class Scenario(XMLScenarioFileLoading):

    @classmethod
    def deserialize_scenario(cls, *name):
        scenario_node_list = cls.get_scenario_node_list(*name)
        scenario_list: [ScenarioNode] = []
        for scenario_node in scenario_node_list:
            new_scenario_node = ScenarioNode(scenario_node.attrib.get('id'))
            new_scenario_node.pressure_low = cls.get_scenario_pressure_lower(scenario_node)
            new_scenario_node.pressure_upper = cls.get_scenario_pressure_upper(scenario_node)
            new_scenario_node.flow = cls.get_scenario_flow(scenario_node)
            new_scenario_node.contract_pressure_max = cls.get_scenario_contract_pressure_max(scenario_node)
            print(new_scenario_node)
            scenario_list.append(new_scenario_node)
        return scenario_list


    @classmethod
    def get_scenario_pressure(cls, scenario_node):
        return scenario_node.findall('gas:pressure', ns)

    @classmethod
    def get_scenario_pressure_lower(cls, scenario_node):
        pressure_list = cls.get_scenario_pressure(scenario_node)
        if len(pressure_list) > 0:
            for pressure in pressure_list:
                if pressure.attrib.get('bound') == 'lower':
                    return float(pressure.attrib.get('value'))
        return None

    @classmethod
    def get_scenario_pressure_upper(cls, scenario_name):
        pressure_list = cls.get_scenario_pressure(scenario_name)
        if len(pressure_list) > 0:
            for pressure in pressure_list:
                if pressure.attrib.get('bound') == 'upper':
                    return float(pressure.attrib.get('value'))
        return None

    @classmethod
    def get_scenario_flow(cls, scenario_node):
        return float(scenario_node.find('gas:flow', ns).attrib.get('value'))

    @classmethod
    def get_scenario_contract_pressure_max(cls, scenario_name):
        contract_pressure = scenario_name.find('gas:contractPressureMax', ns)
        return float(contract_pressure.attrib.get('value')) if contract_pressure is not None else None

print(Scenario.deserialize_scenario('data', 'GasLib-582', 'GasLib-582.scn'))