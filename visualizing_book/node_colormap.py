import matplotlib.pyplot as plt
import networkx as nx

# G = nx.cycle_graph(24)
# pos = nx.spring_layout(G, iterations = 2000)
# nx.draw(G, pos, node_color = range(24), node_size=800, cmap=plt.cm.Reds)
# plt.show()



# cmaps['Sequential'] = [
#             'Greys', 'Purples', 'Blues', 'Greens', 'Oranges', 'Reds',
#             'YlOrBr', 'YlOrRd', 'OrRd', 'PuRd', 'RdPu', 'BuPu',
#             'GnBu', 'PuBu', 'YlGnBu', 'PuBuGn', 'BuGn', 'YlGn']

#edge coloring
H = nx.star_graph(20)
pos = nx.spring_layout(H)
colors = range(20)
nx.draw(H, pos, node_color=range(21), edge_color=colors,
        width=4, edge_cmap=plt.cm.Blues, with_labels=False)
plt.show()