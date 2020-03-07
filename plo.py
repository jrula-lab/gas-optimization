from pyscipopt import Model, quicksum, multidict


def point_set_example_a():
    return multidict({0: (0, 0), 0.33: (1.56, -0.167), 0.67: (2.22, -1), 1: (2, -2.5)})


def model_definition(X: list):
    model = Model("Example A")
    lamb1, lamb2 = {}, {}
    for i, x in enumerate(X):
        lamb1[x] = model.addVar(lb=0, ub=1, name="L1[%d]" % i)
        lamb2[x] = model.addVar(lb=0, ub=1, name="L2[%d]" % i)

    model.addCons(quicksum(lamb1[x] * x for x in X) <= 1)
    model.addCons(quicksum(lamb2[x] * x for x in X) <= 1)
    x1 = 5 * quicksum(lamb1[x] * x for x in X)
    x2 = quicksum(lamb2[x] * x for x in X)
    model.addCons(x1 + x2 >= 3)
    return model, lamb1, lamb2


def model_definition1():
    model = Model('Example A')
    lamb11 = model.addVar(lb=0, ub=1, name="L1[1]")
    lamb12 = model.addVar(lb=0, ub=1, name="L1[2]")
    lamb13 = model.addVar(lb=0, ub=1, name="L1[3]")
    lamb14 = model.addVar(lb=0, ub=1, name="L1[4]")
    lamb21 = model.addVar(lb=0, ub=1, name="L2[1]")
    lamb22 = model.addVar(lb=0, ub=1, name="L2[2]")
    lamb23 = model.addVar(lb=0, ub=1, name="L2[3]")
    lamb24 = model.addVar(lb=0, ub=1, name="L2[4]")

    model.addCons(0*lamb11+0.33 * lamb12 + 0.67 * lamb13 + 1 * lamb14 <= 1)
    model.addCons(0*lamb21+0.33 * lamb22 + 0.67 * lamb23 + 1 * lamb24 <= 1)

    model.addCons(5 * (0*lamb11+0.33 * lamb12 + 0.67 * lamb13 + 1 * lamb14)+ 0*lamb21+ 0.33 * lamb22 + 0.67 * lamb23 + 1 * lamb24 >= 3)
    b1, b2= {}, {}
    for i in [1,2,3]:
        b1[i] = model.addVar(name= "b1[%d]"%i, vtype="B")
        b2[i] = model.addVar(name = "b2[%d]"%i, vtype="B")
    model.addCons(lamb11 <= b1[1])
    model.addCons(lamb12 <= b1[1]+b1[2])
    model.addCons(lamb13 <= b1[2]+b1[3])
    model.addCons(lamb14 <= b1[3])

    model.addCons(lamb21 <= b2[1])
    model.addCons(lamb22 <= b2[1]+b2[2])
    model.addCons(lamb23 <= b2[2]+b2[3])
    model.addCons(lamb24 <= b2[3])
    model.addCons(b1[1]+b1[2]+b1[3] ==1)
    model.addCons(b2[1]+b2[2]+b2[3]==1)
    model.setObjective(0*lamb11+0*lamb21+1.56 * lamb12 + 2.22 * lamb13 + 2 * lamb14 - 0.167 * lamb22 - 1 * lamb23 - 2.5 * lamb24,
                       "minimize")
    model.optimize()
    print("Optimal value=", model.getVal(lamb11))
    print("Optimal value=", model.getVal(lamb12))
    print("Optimal value=", model.getVal(lamb13))
    print("Optimal value=", model.getVal(lamb14))
    print("Optimal value=", model.getVal(lamb21))
    print("Optimal value=", model.getVal(lamb22))
    print("Optimal value=", model.getVal(lamb23))
    print("Optimal value=", model.getVal(lamb24))

    print("Optimal value=", model.getVal(b1[1]))
    print("Optimal value=", model.getVal(b1[2]))
    print("Optimal value=", model.getVal(b1[3]))

    print("Optimal value=", model.getVal(b2[1]))
    print("Optimal value=", model.getVal(b2[2]))
    print("Optimal value=", model.getVal(b2[3]))



if __name__ == "__main__":
    f1 = [0, 1.56, 2.22, 2]
    f2 = [0, -0.167, -1, -2.5]
    X = [0, 0.33, 0.67, 1]

    for i, x in enumerate(X):
        print(str(i) + " " + str(x))

    model, lamb1, lamb2 = model_definition(X)
    fx1 = quicksum(lamb1[x] * f1[i] for i, x in enumerate(X))
    fx2 = quicksum(lamb2[x] * f2[i] for i, x in enumerate(X))
    model.setObjective(fx1 + fx2, "minimize")
    model.optimize()
    for x in X:
        print("Optimal value=", model.getVal(lamb1[x]))
        print("Optimal value=", model.getVal(lamb2[x]))

    print("\n\n\n\n\n")
    model_definition1()
