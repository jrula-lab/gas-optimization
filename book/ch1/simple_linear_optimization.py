from pyscipopt import Model

model = Model("Simple linear optymization")

x1 = model.addVar(vtype="C", name="x1")
x2 = model.addVar(vtype="C", name="x2")
x3 = model.addVar(vtype="C", name="x3")

model.addCons(2 * x1 + x2 + x3 <= 60)
model.addCons(x1 + 2 * x2 + x3 <= 60)
model.addCons(x3 <= 30)
model.addCons(x1 >= 0)
model.addCons(x2 >= 0)
model.addCons(x3 >= 0)
model.setObjective(15*x1+18*x2+30*x3, "maximize")
model.optimize()

if model.getStatus() == "optimal":
    print("Optimal value: {}".format(model.getObjVal()))
    print("Solution")
    print(" x1 = {}".format(model.getVal(x1)))
    print(" x2 = {}".format(model.getVal(x2)))
    print(" x3 = {}".format(model.getVal(x3)))

else:
    print("Problem could not be solved to optimality")
