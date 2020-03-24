# Author: Aric Hagberg (hagberg@lanl.gov)
import matplotlib.pyplot as plt
import networkx as nx

G = nx.house_graph()
# explicitly set positions
pos = {0: (0, 0),
       1: (1, 0),
       2: (0, 10),
       3: (1, 10),
       4: (0.5, 2.0)}           

nx.draw_networkx_nodes(G, pos, node_size=2000, nodelist=[4], with_labels= True)
nx.draw_networkx_nodes(G, pos, node_size=3000, nodelist=[0, 1, 2, 3], node_color='b', with_labels = True)
nx.draw_networkx_edges(G, pos, alpha=0.5, width=6)
plt.axis('off')
plt.show()