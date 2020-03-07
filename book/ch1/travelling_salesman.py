from pyscipopt import Model, multidict
from pyscipopt import quicksum, SCIP_RESULT


def mkp(I, J, v, a, b):
    model = Model("mkp")
    x = {}
    for j in J:
        x[j] = model.addVar(vtype="B", name="x[%d]" % j)
    # model.update()
    for i in I:
        model.addCons(quicksum(a[i, j] * x[j] for j in J) <= b[i], "Dimension[%d]" % i)
    model.setObjective(quicksum(v[j] * x[j] for j in J))
    # model.update()
    return model


J, v = multidict({1: 16, 2: 19, 3: 23, 4: 28})
a = {(1, 1): 2, (1, 2): 3, (1, 3): 4, (1, 4): 5,
     (2, 1): 3000, (2, 2): 3500, (2, 3): 5100, (2, 4): 7200,
     }
I, b = multidict({1: 7, 2: 10000})

model = mkp(I, J, v, a, b)
# model.ModelSense = -1
model.optimize()
print("Optimal value=", model.getObjVal())
EPS = 1.e-6
# for v in model.getVars():
#     if v.X > EPS:
#         print(v.VarName, v.X)

print(SCIP_RESULT.INFEASIBLE)
