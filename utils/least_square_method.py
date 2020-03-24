from typing import Callable

from scipy.optimize import leastsq


def func(params, x):
    a, b, c = params
    return a * x * x + b * x + c


def error(params, x, y):
    return func(params, x) - y


def slovePara(X, Y):
    p0 = [10, 10, 10]
    Para = leastsq(error, p0, args=(X, Y))
    return Para


def least_square_solution(X, Y) -> Callable:
    Para = slovePara(X, Y)
    a, b, c = Para[0]
    return lambda x: a * x * x + b * x + c
