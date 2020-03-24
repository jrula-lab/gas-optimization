import sys

import matplotlib.pyplot as plt
import networkx as nx

G = nx.grid_2d_graph(5,5)

for line in nx.generate_adjlist(G):
    print(line)

nx.write_edgelist(G, path="grind.edgelist", delimiter=":")

H = nx.read_edgelist(path="grind.edgelist", delimiter=":")

nx.draw(G)

plt.show()

