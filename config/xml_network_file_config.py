from config.ns import ns
from config.xml_file_config import XMLFileReadingConfig


class XMLNetworkFileLoading(XMLFileReadingConfig):

    @classmethod
    def get_connections_elements(cls, *name):
        connections = cls.open_xml_file(*name)
        return connections

    @classmethod
    def get_pipes_elements(cls, *name):
        pipes = cls.get_connections_elements(*name)
        return pipes.iter('gas:pipe')



print(XMLNetworkFileLoading.get_pipes_elements('data', 'GasLib-11', 'GasLib-11.net'))