import logging
import os
from pathlib import Path

from config.yaml_file_config import ConfigYamlLoad

ROOT_DIR = Path(__file__).parent.parent

class Logger:
    def __init__(self, file_name: str):
        file_path = os.path.join(ROOT_DIR, "logs", file_name)
        self.f = open(file_path, "a")

    def print_something(self):
        self.f.write("something")
        self.f.close()

