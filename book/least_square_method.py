#!/usr/bin/env python
# coding:utf-8
# A method of fitting quadratic parabolic function with least squares in Python
# https://developpaper.com/a-method-of-fitting-quadratic-parabolic-function-with-least-squares-in-python/

import numpy as np
import matplotlib.pyplot as plt
from scipy.optimize import leastsq

# Data to be fitted
X = np.array([1, 2, 3, 4, 5, 6])
Y = np.array([9.1, 18.3, 32, 47, 69.5, 94.8])


# Standard Form of Quadratic Function
def func(params, x):
    a, b, c = params
    return a * x * x + b * x + c


# Error function, that is, the difference between the value obtained by fitting curve and the actual value
def error(params, x, y):
    return func(params, x) - y


# Solving parameters
def slovePara():
    p0 = [10, 10, 10]
    print(X)
    print(Y)
    Para = leastsq(error, p0, args=(X, Y))
    return Para


# Output the final result
def solution(X, Y):
    Para = slovePara()
    a, b, c = Para[0]
    print("a=", a, " b=", b, " c=", c)
    print("cost:" + str(Para[1]))
    print("The curve of solution is:")
    print("y=" + str(round(a, 2)) + "x*x+" + str(round(b, 2)) + "x+" + str(c))

    plt.figure(figsize=(8, 6))
    plt.scatter(X, Y, color="green", label="sample data", linewidth=2)
    red_points_number = max(X)
    red_points_number_start = min(X)

    # Drawing Fitted Lines
    x = np.linspace(red_points_number_start - red_points_number_start * 0.1,
                    red_points_number + 0.1 * red_points_number,
                    red_points_number * 30)  # draw 100 continuous points directly from 0 to 12
    y = a * x * x + b * x + c  # # function
    plt.plot(x, y, color="red", label="solution line", linewidth=2)
    plt.legend()  # Draw Legend
    plt.show()


def generate_energy_consumption(x):
    return 0.0 * x * x + 1.01 * x + 7488.999999999995


def generate_maximum_power(x):
    return 0.0 * x * x + 24.42 * x + 230.5147058823585


# energy_consumption = generate_energy_consumption(
#     np.array([5250, 5500, 5750, 6000, 6250, 6500, 6750, 7000, 7250, 7500, 7750, 8000, 8250, 8500, 8750]))
# maximum_power = generate_maximum_power(np.array([165, 180, 195, 210, 225, 240, 250, 265, 280, 295, 310, 330]))
#
X = np.array([5250, 7000, 8750])
Y = np.array([15997, 20621, 25329])
solution(X, Y)
#
# X = np.array([5250, 5500, 5750, 6000, 6250, 6500, 6750, 7000, 7250, 7500, 7750, 8000, 8250, 8500, 8750])
# Y = np.array(energy_consumption)
# solution(X, Y)
# X = np.array([165, 180, 195, 210, 225, 240, 250, 265, 280, 295, 310, 330])
# Y = np.array(maximum_power)
# solution(X, Y)


def generate_load(t):
    return 1 * (1 + 0.3 * np.sin(t / (2 * np.pi * t.size)) * np.sin(t / 2.5))


def show_load_generator_function():
    t = []
    # for i in range(1440):
    #     if i % 10 == 0:
    #         t.append(i)
    for i in range(24):
        t.append(i)

    x = np.array(t)
    y = generate_load(x)
    print(y)
    plt.plot(x, y, color="red", label="solution line", linewidth=2)
    plt.legend()  # Draw Legend
    plt.show()


# show_load_generator_function()

#przykład danych rzeczywistego zapotrzebowania na gaz  książka "Sieci i instalacje gazowe" strona 241-242
