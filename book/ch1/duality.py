#
# Let us assume that an entrepreneur is interested in the wine making company and would like to buy its resources.
# The entrepreneur then needs to find out how much to pay for each unit of each of the resources, the pure-grape wines
# of 2010 A, B and C. This can be done by solving the dual version of the model that we will discuss next.

from pyscipopt import Model

model = Model("duality with wine factory example")
y1 = model.addVar(vtype="C", name="y1")
y2 = model.addVar(vtype="C", name="y2")
y3 = model.addVar(vtype="C", name="y3")

model.addCons(2 * y1 + y2 >= 15)
model.addCons(y1 + 2 * y2 >= 18)
model.addCons(y1 + y2 + y3 >= 30)
model.addCons(y1 >= 0)
model.addCons(y2 >= 0)
model.addCons(y3 >= 0)
model.setObjective(60 * y1 + 60 * y2 + 30 * y3)
model.optimize()
if model.getStatus() == "optimal":
    print("Optimal value: {}".format(model.getObjVal()))
    print("Solution:")
    print(" x = {}".format(model.getVal(y1)))
    print(" y = {}".format(model.getVal(y2)))
    print(" z = {}".format(model.getVal(y3)))
else:
    print("Problem could not be solved to optimality")
