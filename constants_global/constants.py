compressibility_factor_normal: float = 1.0
pressure_normal: float = 101325
temperature_normal: float = 273.15
universal_gas_constant: float = 8314.4621  # J/kg*kmol
gravitational_acceleration: float = 9.80665
boltzman_constant: float = 1.3806488 * 10 ** (-23)
avogadro_constant: float = 6.02214129 * 10 ** (23)
gas_density_normal: float = 1.0
pseudo_critical_temperature: float = 202.2024395142
isentropic_exponent: float = 1.296
reduced_temperature: float = None  # todo assigned in source there is only one first read
gas_temperature: float = None  # todo assigned in source there is only one first read
molar_mass: float = None
pseudo_critical_pressure: float = None
adiabatic_efficiency: float = 0.95
scenario_file = ('data', 'GasLib-11', 'GasLib-11.scn')
network_file = ('data', 'GasLib-11', 'GasLib-11.net')
gas_calorific_value: float = None


def calculate_reduced_temperature(pseudo_critical_temperature: float, temperature: float):
    global reduced_temperature
    global gas_temperature
    reduced_temperature = temperature / pseudo_critical_temperature
    gas_temperature = temperature


def read_molar_mass(mass: float):
    global molar_mass
    molar_mass = mass


def read_pseudo_critical_pressure(pressure: float):
    global pseudo_critical_pressure
    pseudo_critical_pressure = pressure


def compressibility_factor_papay_formula(pressure: float) -> float:
    import numpy as np
    return 1 - 3.52 * (pressure / pseudo_critical_pressure) * np.e ** (-2.26 * reduced_temperature) + 0.274 * (
            pressure / pseudo_critical_pressure) ** 2 * np.e ** (-1.878 * reduced_temperature)


def read_gas_calorific_value(calorific_value: float):
    global gas_calorific_value
    gas_calorific_value = calorific_value
