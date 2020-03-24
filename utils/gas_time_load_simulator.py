import numpy as np


# todo gas load per one hour in 24 hours range
def generate_gas_load(t):
    return 1 * (1 + 0.3 * np.sin(t / (2 * np.pi * t.size)) * np.sin(t / 2.5))
