import os

import yaml


class ConfigYamlLoad:
    YAML_PATH_FILE_NAME: str = 'paths'
    basedir = os.path.abspath(os.path.dirname(__file__))

    @classmethod
    def get_yaml_file(cls):
        return cls.load_yaml('other', cls.YAML_PATH_FILE_NAME + '.yaml')

    @classmethod
    def load_yaml(cls, *path_name):
        with open(cls.to_root_path(*path_name)) as f:
            return yaml.safe_load(f)

    @classmethod
    def to_root_path(cls, *path_args):
        return os.path.join(cls.basedir, *path_args)

    @classmethod
    def get_config_value(cls, config_dict, dict_path):
        ok = True
        temp = config_dict
        for key in dict_path.split('.'):
            if key in temp:
                temp = temp[key]
                continue
            else:
                ok = False
                break
        if ok:
            return temp
        raise KeyError('Key {} not found in test configuration file.'.format(dict_path))

    @classmethod
    def get_yaml_value(cls, key: str):
        return cls.get_config_value(cls.get_yaml_file(), key)



