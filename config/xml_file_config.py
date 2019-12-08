import os
import xml.etree.ElementTree as ET

from config.yaml_file_config import ConfigYamlLoad


class XMLFileReadingConfig(ConfigYamlLoad):
    DATA_DIRECTORY = os.path.abspath(os.path.dirname(__file__))

    @classmethod
    def to_file_data_path(cls, *path_args):
        return os.path.join(cls.DATA_DIRECTORY, '..', *path_args)

    @classmethod
    def open_xml_file(cls, *name):
        my_tree = ET.parse(cls.to_file_data_path(*name))
        return my_tree.getroot()


