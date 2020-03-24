from typing import Tuple
import numpy as np


def convert_array_tuple_to_np_array(list_to_convert: [Tuple]) -> Tuple:
    x_list = []
    y_list = []
    for element in list_to_convert:
        x_list.append(element[0])
        y_list.append(element[1])
    return (np.array(x_list), np.array(y_list))
