# The objective of the problem is to minimize the sum of facility activation costs and transportation costs.
# The first constraints require that each customer’s demand must be satisfied. The capacity of each facility j
# is limited by the second constraints: if facility j is activated, its capacity restriction is observed; if it is not
# activated, the demand satisfied by j is zero. Third constraints provide variable upper bounds; even though they are
# redundant, they yield a much tighter linear programming relaxation than the equivalent, weaker formulation without
# them, as will be discussed in the next section.
from pyscipopt import Model, quicksum, multidict


def flp(I, J, d, M, f, c):
    model = Model("flp")
    x, y = {}, {}
    for j in J:
        y[j] = model.addVar(vtype="B", name="y(%s)" % j)
        for i in I:
            x[i, j] = model.addVar(vtype="C", name="x(%s,%s)" % (i, j))
    for i in I:
        model.addCons(quicksum(x[i, j] for j in J) == d[i], "Demand(%s)" % i)
    for j in M:
        model.addCons(quicksum(x[i, j] for i in I) <= M[j] * y[j], "Capacity(%s)" % i)
    for (i, j) in x:
        model.addCons(x[i, j] <= d[i] * y[j], "Strong(%s,%s)" % (i, j))
    model.setObjective(
        quicksum(f[j] * y[j] for j in J) +
        quicksum(c[i, j] * x[i, j] for i in I for j in J),
        "minimize")
    model.data = x, y
    return model


I, d = multidict({1: 80, 2: 270, 3: 250, 4: 160, 5: 180})
J, M, f = multidict({1: [500, 1000], 2: [500, 1000], 3: [500, 1000]})
c = {(1, 1): 4, (1, 2): 6, (1, 3): 9,
     (2, 1): 5, (2, 2): 4, (2, 3): 7,
     (3, 1): 6, (3, 2): 3, (3, 3): 4,
     (4, 1): 8, (4, 2): 5, (4, 3): 3,
     (5, 1): 10, (5, 2): 8, (5, 3): 4,
     }

model = flp(I, J, d, M, f, c)
model.optimize()
EPS = 1.e-6
x, y = model.data
edges = [(i, j) for (i, j) in x if model.getVal(x[i, j]) > EPS]
facilities = [j for j in y if model.getVal(y[j]) > EPS]
print("Optimal value=", model.getObjVal())
print("Facilities at nodes:", facilities)
print("Edges:", edges)
