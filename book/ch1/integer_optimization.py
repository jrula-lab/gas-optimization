#  Adding the number of heads of cranes, turtles and octopuses totals 32, and the number of legs sums to 80.
#  What is the minimum number of turtles and octopuses?
# Let us formalize this as an optimization problem with mathematical formulas. This process of describing
#  a situation algebraically is called the formulation of a problem in mathematical optimization.

from pyscipopt import Model

model = Model('How many heads and legs puzzle riddle')

x = model.addVar(vtype="I", name="x")
y = model.addVar(vtype="I", name="y")
z = model.addVar(vtype="I", name="z")

model.addCons(x + y + z == 32, "Heads")
model.addCons(2 * x + 4 * y + 8 * z == 80, "Legs")
model.addCons(x >= 0)
model.addCons(y >= 0)
model.addCons(z >= 0)
model.setObjective(y + z)
model.optimize()
if model.getStatus() == "optimal":
    print("Optimal value: {}".format(model.getObjVal()))
    print("Solution:")
    print(" x = {}".format(model.getVal(x)))
    print(" y = {}".format(model.getVal(y)))
    print(" z = {}".format(model.getVal(z)))
else:
    print("Problem could not be solved to optimality")
