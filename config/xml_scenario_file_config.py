from config.ns import ns
from config.xml_file_config import XMLFileReadingConfig


class XMLScenarioFileLoading(XMLFileReadingConfig):

    @classmethod
    def get_scenario(cls, *name):
        scenarios = cls.open_xml_file(*name)
        return scenarios.findall('gas:scenario', ns)

    @classmethod
    def get_scenario_node_list(cls, *name):
        scenario_node_list = []
        scenarios = cls.get_scenario(*name)
        for scenario in scenarios:
            for scenario_node in scenario.iterfind('gas:node', ns):
                print(scenario_node)
                ([print(i.get('bound')) for i in scenario_node.findall('gas:flow', ns)])
                print(scenario_node.find('gas:flow', ns).attrib.get('bound'))
                scenario_node_list.append(scenario_node)
        return scenario_node_list


print(XMLScenarioFileLoading.get_scenario_node_list('data', 'GasLib-11', 'GasLib-11.scn'))
