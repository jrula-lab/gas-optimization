#
# You are the owner of a sports equipment sales chain. Your products are manufactured at three factories,
# and you have to deliver them to five customers (demand points) (Figure Transportation problem).
# After elaborating a survey, you found that the production capacity at each factory,
# the transportation cost to customers, and the demand amount at each customer are as shown in
# Table Data for the transportation problem. So, which of the transport routes would you choose to minimize the total cost?
from pyscipopt import Model
from pyscipopt import quicksum

demand = {1: 80, 2: 270, 3: 250, 4: 160, 5: 180}
capacity = {1: 500, 2: 500, 3: 500}
I = [1, 2, 3, 4, 5]
J = [1, 2, 3]
cost = {(1, 1): 4, (1, 2): 6, (1, 3): 9,
        (2, 1): 5, (2, 2): 4, (2, 3): 7,
        (3, 1): 6, (3, 2): 3, (3, 3): 3,
        (4, 1): 8, (4, 2): 5, (4, 3): 3,
        (5, 1): 10, (5, 2): 8, (5, 3): 4,
        }

model = Model("transportation problem")
x = {}
for i in I:
    for j in J:
        x[i, j] = model.addVar(vtype="C", name="x(%s,%s)" % (i, j))

for i in I:
    model.addCons(quicksum(x[i, j] for j in J if (i, j) in x) == demand[i], "Demand(%s)" % i)

for j in J:
    model.addCons(quicksum(x[i, j] for i in I if (i, j) in x) <= capacity[j], "Capacity(%s)" % j)

model.setObjective(quicksum(cost[i, j] * x[i, j] for (i, j) in x), "minimize")

model.optimize()
print("Optimal value: {}".format(model.getObjVal()))
EPS = 1.e-6
for (i, j) in x:
    if model.getVal(x[i, j]) > EPS:
        print("Sending quantity %10s from factory %3s to customer %3s" % (model.getVal(x[i, j]), i, j))
