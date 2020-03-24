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
scenario_file = ('data', 'GasLib-582', 'GasLib-582.scn')
network_file = ('data', 'GasLib-582', 'GasLib-582.net')


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
