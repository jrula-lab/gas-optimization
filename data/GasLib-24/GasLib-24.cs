<?xml version="1.0" encoding="UTF-8"?>

<!-- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -->
<!--                                                                                   -->
<!--                  This file is part of the BMWi project 0328006                    -->
<!--                      Technical Capacities of Gas Networks                         -->
<!--                                                                                   -->
<!-- Copyright (C) 2013                                                                -->
<!-- FAU Erlangen-Nuremberg, HU Berlin, LU Hannover, TU Darmstadt,                     -->
<!-- University Duisburg-Essen, WIAS Berlin, Zuse Institute Berlin                     -->
<!-- Contact: Thorsten Koch (koch@zib.de)                                              -->
<!-- All rights reserved.                                                              -->
<!--                                                                                   -->
<!-- This work is licensed under the Creative Commons Attribution 3.0 Unported License.-->
<!-- To view a copy of this license, visit http://creativecommons.org/licenses/by/3.0/ -->
<!-- or send a letter to Creative Commons, 444 Castro Street, Suite 900, Mountain View,-->
<!-- California, 94041, USA.                                                           -->
<!--                                                                                   -->
<!--                         Please note that you have to cite                         -->
<!-- Pfetsch et al. (2012) "Validation of Nominations in Gas Network Optimization:     -->
<!-- Models, Methods, and Solutions", ZIB-Report 12-41                                 -->
<!--                               if you use this data                                -->
<!--                                                                                   -->
<!-- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -->


<compressorStations xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                    xmlns="http://gaslib.zib.de/CompressorStations"
                    xsi:schemaLocation="http://gaslib.zib.de/CompressorStations CompressorStations.xsd"
                    xmlns:gas="http://gaslib.zib.de/Gas"
                    xmlns:framework="http://gaslib.zib.de/CompressorStations">

  <compressorStation id="CS3">
    <compressors>
      <turboCompressor drive="P_CS3_M1" id="T_CS3_M1">
        <speedMin value="5760" unit="per_min"/>
        <speedMax value="11600" unit="per_min"/>
        <n_isoline_coeff_1 value="-9.12322"/>
        <n_isoline_coeff_2 value="0.00210668"/>
        <n_isoline_coeff_3 value="6.98297e-08"/>
        <n_isoline_coeff_4 value="10.5641"/>
        <n_isoline_coeff_5 value="-0.000118454"/>
        <n_isoline_coeff_6 value="1.33695e-07"/>
        <n_isoline_coeff_7 value="-10.5647"/>
        <n_isoline_coeff_8 value="0.00066203"/>
        <n_isoline_coeff_9 value="-3.50873e-08"/>
        <eta_ad_isoline_coeff_1 value="1.30278"/>
        <eta_ad_isoline_coeff_2 value="-0.000270673"/>
        <eta_ad_isoline_coeff_3 value="1.36268e-08"/>
        <eta_ad_isoline_coeff_4 value="0.369272"/>
        <eta_ad_isoline_coeff_5 value="0.000203381"/>
        <eta_ad_isoline_coeff_6 value="-1.52423e-08"/>
        <eta_ad_isoline_coeff_7 value="-0.773616"/>
        <eta_ad_isoline_coeff_8 value="6.19194e-05"/>
        <eta_ad_isoline_coeff_9 value="-6.35666e-10"/>
        <surgeline_coeff_1 value="-77.6315"/>
        <surgeline_coeff_2 value="118.291"/>
        <surgeline_coeff_3 value="-24.711"/>
        <chokeline_coeff_1 value="0.168279"/>
        <chokeline_coeff_2 value="-0.228376"/>
        <chokeline_coeff_3 value="2.47995"/>
      </turboCompressor>
      <turboCompressor drive="P_CS3_M3" id="T_CS3_M3">
        <speedMin value="3250" unit="per_min"/>
        <speedMax value="6500" unit="per_min"/>
        <n_isoline_coeff_1 value="-9.83925"/>
        <n_isoline_coeff_2 value="0.00547121"/>
        <n_isoline_coeff_3 value="-1.81485e-07"/>
        <n_isoline_coeff_4 value="3.23015"/>
        <n_isoline_coeff_5 value="0.000135477"/>
        <n_isoline_coeff_6 value="2.66927e-07"/>
        <n_isoline_coeff_7 value="-2.29291"/>
        <n_isoline_coeff_8 value="0.000177414"/>
        <n_isoline_coeff_9 value="-2.45398e-08"/>
        <eta_ad_isoline_coeff_1 value="1.12015"/>
        <eta_ad_isoline_coeff_2 value="-0.000162661"/>
        <eta_ad_isoline_coeff_3 value="-1.02418e-08"/>
        <eta_ad_isoline_coeff_4 value="-0.147143"/>
        <eta_ad_isoline_coeff_5 value="0.000206941"/>
        <eta_ad_isoline_coeff_6 value="-1.63499e-08"/>
        <eta_ad_isoline_coeff_7 value="-0.1207"/>
        <eta_ad_isoline_coeff_8 value="8.03558e-06"/>
        <eta_ad_isoline_coeff_9 value="3.60559e-10"/>
        <surgeline_coeff_1 value="-32.0323"/>
        <surgeline_coeff_2 value="27.6425"/>
        <surgeline_coeff_3 value="-2.16445"/>
        <chokeline_coeff_1 value="-0.805924"/>
        <chokeline_coeff_2 value="1.33227"/>
        <chokeline_coeff_3 value="0.485853"/>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="P_CS3_M1">
        <energy_rate_fun_coeff_1 value="4001.75"/>
        <energy_rate_fun_coeff_2 value="2.60807"/>
        <energy_rate_fun_coeff_3 value="4.44444e-07"/>
        <power_fun_coeff_1 value="40.5292"/>
        <power_fun_coeff_2 value="0.596874"/>
        <power_fun_coeff_3 value="-2.49782e-05"/>
        <power_fun_coeff_4 value="-0.321905"/>
        <power_fun_coeff_5 value="-0.00366792"/>
        <power_fun_coeff_6 value="1.53529e-07"/>
        <power_fun_coeff_7 value="0.00123383"/>
        <power_fun_coeff_8 value="4.37942e-06"/>
        <power_fun_coeff_9 value="-2.00809e-10"/>
      </gasTurbine>
      <gasTurbine id="P_CS3_M3">
        <energy_rate_fun_coeff_1 value="5598.75"/>
        <energy_rate_fun_coeff_2 value="2.53053"/>
        <energy_rate_fun_coeff_3 value="-4.36571e-08"/>
        <power_fun_coeff_1 value="-2650.98"/>
        <power_fun_coeff_2 value="3.5559"/>
        <power_fun_coeff_3 value="-0.000233106"/>
        <power_fun_coeff_4 value="18.5286"/>
        <power_fun_coeff_5 value="-0.0246771"/>
        <power_fun_coeff_6 value="1.6213e-06"/>
        <power_fun_coeff_7 value="-0.0778571"/>
        <power_fun_coeff_8 value="0.000103668"/>
        <power_fun_coeff_9 value="-6.86813e-09"/>
      </gasTurbine>
    </drives>
    <configurations>

      <configuration confId="1" nrOfSerialStages="2">
        <stage stageNr="1" nrOfParallelUnits="1">
          <compressor id="T_CS3_M1" nominalSpeed="5200"/>
        </stage>
        <stage stageNr="2" nrOfParallelUnits="1">
          <compressor id="T_CS3_M3" nominalSpeed="5200"/>
        </stage>
      </configuration>

      <configuration confId="3" nrOfSerialStages="1">
        <stage stageNr="1" nrOfParallelUnits="1">
          <compressor id="T_CS3_M1" nominalSpeed="5200"/>
        </stage>
      </configuration>

      <configuration confId="2" nrOfSerialStages="1">
        <stage stageNr="1" nrOfParallelUnits="2">
          <compressor id="T_CS3_M1" nominalSpeed="5200"/>
          <compressor id="T_CS3_M3" nominalSpeed="5200"/>
        </stage>
      </configuration>

      <configuration confId="4" nrOfSerialStages="1">
        <stage stageNr="1" nrOfParallelUnits="1">
          <compressor id="T_CS3_M3" nominalSpeed="5200"/>
        </stage>
      </configuration>

    </configurations>
  </compressorStation>

  <compressorStation id="CS2">
    <compressors>
      <turboCompressor drive="P_CS2_M4" id="T_CS2_M4">
        <speedMin value="3500" unit="per_min"/>
        <speedMax value="6500" unit="per_min"/>
        <n_isoline_coeff_1 value="62.0918"/>
        <n_isoline_coeff_2 value="-0.0292953"/>
        <n_isoline_coeff_3 value="4.29877e-06"/>
        <n_isoline_coeff_4 value="-58.9579"/>
        <n_isoline_coeff_5 value="0.0265692"/>
        <n_isoline_coeff_6 value="-2.57876e-06"/>
        <n_isoline_coeff_7 value="4.32767"/>
        <n_isoline_coeff_8 value="-0.00240606"/>
        <n_isoline_coeff_9 value="2.45649e-07"/>
        <eta_ad_isoline_coeff_1 value="1.16239"/>
        <eta_ad_isoline_coeff_2 value="-0.000178625"/>
        <eta_ad_isoline_coeff_3 value="6.8119e-09"/>
        <eta_ad_isoline_coeff_4 value="-0.063803"/>
        <eta_ad_isoline_coeff_5 value="8.29481e-05"/>
        <eta_ad_isoline_coeff_6 value="-6.36087e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.0327073"/>
        <eta_ad_isoline_coeff_8 value="1.43794e-06"/>
        <eta_ad_isoline_coeff_9 value="1.02304e-10"/>
        <surgeline_coeff_1 value="-49.8997"/>
        <surgeline_coeff_2 value="27.7343"/>
        <surgeline_coeff_3 value="-0.0449561"/>
        <chokeline_coeff_1 value="-11.7751"/>
        <chokeline_coeff_2 value="7.27912"/>
        <chokeline_coeff_3 value="0.0567136"/>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="P_CS2_M4">
        <energy_rate_fun_coeff_1 value="5000"/>
        <energy_rate_fun_coeff_2 value="2.5"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1507.55"/>
        <power_fun_coeff_2 value="3.23595"/>
        <power_fun_coeff_3 value="-0.000215272"/>
        <power_fun_coeff_4 value="9.38"/>
        <power_fun_coeff_5 value="-0.02044"/>
        <power_fun_coeff_6 value="1.35429e-06"/>
        <power_fun_coeff_7 value="0.0448214"/>
        <power_fun_coeff_8 value="-8.49405e-05"/>
        <power_fun_coeff_9 value="5.83333e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration confId="1" nrOfSerialStages="1">
        <stage stageNr="1" nrOfParallelUnits="1">
          <compressor id="T_CS2_M4" nominalSpeed="5200"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>

  <compressorStation id="CS1">
    <compressors>
      <turboCompressor drive="Turb11" id="Comp11">
        <speedMin unit="per_min" value="5760"/>
        <speedMax unit="per_min" value="11600"/>
        <n_isoline_coeff_1 value="-9.12494"/>
        <n_isoline_coeff_2 value="0.00210704"/>
        <n_isoline_coeff_3 value="6.98108e-08"/>
        <n_isoline_coeff_4 value="10.566"/>
        <n_isoline_coeff_5 value="-0.00011885"/>
        <n_isoline_coeff_6 value="1.33716e-07"/>
        <n_isoline_coeff_7 value="-10.5652"/>
        <n_isoline_coeff_8 value="0.00066214"/>
        <n_isoline_coeff_9 value="-3.50928e-08"/>
        <eta_ad_isoline_coeff_1 value="1.30314"/>
        <eta_ad_isoline_coeff_2 value="-0.000270759"/>
        <eta_ad_isoline_coeff_3 value="1.36317e-08"/>
        <eta_ad_isoline_coeff_4 value="0.368873"/>
        <eta_ad_isoline_coeff_5 value="0.000203474"/>
        <eta_ad_isoline_coeff_6 value="-1.52475e-08"/>
        <eta_ad_isoline_coeff_7 value="-0.77351"/>
        <eta_ad_isoline_coeff_8 value="6.18951e-05"/>
        <eta_ad_isoline_coeff_9 value="-6.34336e-10"/>
        <surgeline_coeff_1 value="-77.6315"/>
        <surgeline_coeff_2 value="118.291"/>
        <surgeline_coeff_3 value="-24.711"/>
        <chokeline_coeff_1 value="0.168264"/>
        <chokeline_coeff_2 value="-0.228366"/>
        <chokeline_coeff_3 value="2.47995"/>
      </turboCompressor>
      <turboCompressor drive="Turb12" id="Comp12">
        <speedMin unit="per_min" value="5760"/>
        <speedMax unit="per_min" value="11600"/>
        <n_isoline_coeff_1 value="-9.12494"/>
        <n_isoline_coeff_2 value="0.00210704"/>
        <n_isoline_coeff_3 value="6.98108e-08"/>
        <n_isoline_coeff_4 value="10.566"/>
        <n_isoline_coeff_5 value="-0.00011885"/>
        <n_isoline_coeff_6 value="1.33716e-07"/>
        <n_isoline_coeff_7 value="-10.5652"/>
        <n_isoline_coeff_8 value="0.00066214"/>
        <n_isoline_coeff_9 value="-3.50928e-08"/>
        <eta_ad_isoline_coeff_1 value="1.30314"/>
        <eta_ad_isoline_coeff_2 value="-0.000270759"/>
        <eta_ad_isoline_coeff_3 value="1.36317e-08"/>
        <eta_ad_isoline_coeff_4 value="0.368873"/>
        <eta_ad_isoline_coeff_5 value="0.000203474"/>
        <eta_ad_isoline_coeff_6 value="-1.52475e-08"/>
        <eta_ad_isoline_coeff_7 value="-0.77351"/>
        <eta_ad_isoline_coeff_8 value="6.18951e-05"/>
        <eta_ad_isoline_coeff_9 value="-6.34336e-10"/>
        <surgeline_coeff_1 value="-77.6315"/>
        <surgeline_coeff_2 value="118.291"/>
        <surgeline_coeff_3 value="-24.711"/>
        <chokeline_coeff_1 value="0.168264"/>
        <chokeline_coeff_2 value="-0.228366"/>
        <chokeline_coeff_3 value="2.47995"/>
      </turboCompressor>
      <turboCompressor drive="Turb13" id="Comp13">
        <speedMin unit="per_min" value="5760"/>
        <speedMax unit="per_min" value="11600"/>
        <n_isoline_coeff_1 value="-9.12494"/>
        <n_isoline_coeff_2 value="0.00210704"/>
        <n_isoline_coeff_3 value="6.98108e-08"/>
        <n_isoline_coeff_4 value="10.566"/>
        <n_isoline_coeff_5 value="-0.00011885"/>
        <n_isoline_coeff_6 value="1.33716e-07"/>
        <n_isoline_coeff_7 value="-10.5652"/>
        <n_isoline_coeff_8 value="0.00066214"/>
        <n_isoline_coeff_9 value="-3.50928e-08"/>
        <eta_ad_isoline_coeff_1 value="1.30314"/>
        <eta_ad_isoline_coeff_2 value="-0.000270759"/>
        <eta_ad_isoline_coeff_3 value="1.36317e-08"/>
        <eta_ad_isoline_coeff_4 value="0.368873"/>
        <eta_ad_isoline_coeff_5 value="0.000203474"/>
        <eta_ad_isoline_coeff_6 value="-1.52475e-08"/>
        <eta_ad_isoline_coeff_7 value="-0.77351"/>
        <eta_ad_isoline_coeff_8 value="6.18951e-05"/>
        <eta_ad_isoline_coeff_9 value="-6.34336e-10"/>
        <surgeline_coeff_1 value="-77.6315"/>
        <surgeline_coeff_2 value="118.291"/>
        <surgeline_coeff_3 value="-24.711"/>
        <chokeline_coeff_1 value="0.168264"/>
        <chokeline_coeff_2 value="-0.228366"/>
        <chokeline_coeff_3 value="2.47995"/>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="Turb11">
        <energy_rate_fun_coeff_1 value="4001.75"/>
        <energy_rate_fun_coeff_2 value="2.60806"/>
        <energy_rate_fun_coeff_3 value="4.45109e-07"/>
        <power_fun_coeff_1 value="40.5236"/>
        <power_fun_coeff_2 value="0.596875"/>
        <power_fun_coeff_3 value="-2.49783e-05"/>
        <power_fun_coeff_4 value="-0.32098"/>
        <power_fun_coeff_5 value="-0.00366812"/>
        <power_fun_coeff_6 value="1.5354e-07"/>
        <power_fun_coeff_7 value="0.00120491"/>
        <power_fun_coeff_8 value="4.3857e-06"/>
        <power_fun_coeff_9 value="-2.01141e-10"/>
      </gasTurbine>
      <gasTurbine id="Turb12">
        <energy_rate_fun_coeff_1 value="4001.75"/>
        <energy_rate_fun_coeff_2 value="2.60806"/>
        <energy_rate_fun_coeff_3 value="4.45109e-07"/>
        <power_fun_coeff_1 value="40.5236"/>
        <power_fun_coeff_2 value="0.596875"/>
        <power_fun_coeff_3 value="-2.49783e-05"/>
        <power_fun_coeff_4 value="-0.32098"/>
        <power_fun_coeff_5 value="-0.00366812"/>
        <power_fun_coeff_6 value="1.5354e-07"/>
        <power_fun_coeff_7 value="0.00120491"/>
        <power_fun_coeff_8 value="4.3857e-06"/>
        <power_fun_coeff_9 value="-2.01141e-10"/>
      </gasTurbine>
      <gasTurbine id="Turb13">
        <energy_rate_fun_coeff_1 value="4001.75"/>
        <energy_rate_fun_coeff_2 value="2.60806"/>
        <energy_rate_fun_coeff_3 value="4.45109e-07"/>
        <power_fun_coeff_1 value="40.5236"/>
        <power_fun_coeff_2 value="0.596875"/>
        <power_fun_coeff_3 value="-2.49783e-05"/>
        <power_fun_coeff_4 value="-0.32098"/>
        <power_fun_coeff_5 value="-0.00366812"/>
        <power_fun_coeff_6 value="1.5354e-07"/>
        <power_fun_coeff_7 value="0.00120491"/>
        <power_fun_coeff_8 value="4.3857e-06"/>
        <power_fun_coeff_9 value="-2.01141e-10"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration confId="1" nrOfSerialStages="1">
        <stage stageNr="1" nrOfParallelUnits="2">
          <compressor id="Comp11" nominalSpeed="5200"/>
          <compressor id="Comp13" nominalSpeed="5200"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>

</compressorStations>
