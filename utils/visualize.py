from typing import Callable

import matplotlib.pyplot as plt
import numpy as np


def draw_scatter_graph(X, Y, figure_size_x: int = 8, figure_size_y: int = 6, line_width: int = 2,
                       label: str = 'sample_data', color: str = 'green'):
    plt.figure(figsize=(figure_size_x, figure_size_y))
    plt.scatter(X, Y, color=color, label=label, linewidth=line_width)
    plt.legend()
    plt.show()


def draw_scatter_line_graph(X, Y, figure_size_x: int = 8, figure_size_y: int = 6, line_width: int = 2,
                            label: str = 'sample_data', color: str = 'green', function_equation: Callable = None,
                            line_graph_lable: str = 'solution line', line_graph_color: str = "red",
                            line_graph_line_width: int = 2):
    plt.figure(figsize=(figure_size_x, figure_size_y))
    plt.scatter(X, Y, color=color, label=label, linewidth=line_width)
    red_points_number = max(X)
    red_points_number_start = min(X)
    x = np.linspace(red_points_number_start - red_points_number_start * 0.1,
                    red_points_number + 0.1 * red_points_number,
                    (int)(red_points_number * 30))
    y = function_equation(x)
    plt.plot(x, y, color=line_graph_color, label=line_graph_lable, linewidth=line_graph_line_width)
    plt.legend()
    plt.show()


def draw_line_graph(X, graph_color: str = "red", graph_label: str = "solution label", graph_line_width: int = 2,
                    function_equation: Callable = None):
    Y = function_equation(X)
    plt.plot(X, Y, color=graph_color, label=graph_label, linewidth=graph_line_width)
    plt.legend()
    plt.show()
