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


<combinedDecisions xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                   xmlns="http://gaslib.zib.de/CombinedDecisions"
                   xsi:schemaLocation="http://gaslib.zib.de/CombinedDecisions CombinedDecisions.xsd"
                   xmlns:framework="http://gaslib.zib.de/Framework">
  <decisionGroup id="dG_1">
    <decision id="d1">
      <compressorStation id="compressorStation_4" value="0"/>
      <valve id="valve_17" value="0"/>
      <valve id="valve_15" value="0"/>
      <valve id="valve_16" value="0"/>
      <valve id="valve_14" value="0"/>
      <valve flowDirection="0" id="valve_12" value="1"/>
    </decision>
    <decision id="d2">
      <compressorStation flowDirection="0" id="compressorStation_4" value="1"/>
      <valve flowDirection="1" id="valve_17" value="1"/>
      <valve flowDirection="1" id="valve_15" value="1"/>
      <valve id="valve_16" value="0"/>
      <valve id="valve_14" value="0"/>
      <valve id="valve_12" value="0"/>
    </decision>
    <decision id="d3">
      <compressorStation id="compressorStation_4" value="0"/>
      <valve id="valve_17" value="0"/>
      <valve flowDirection="1" id="valve_15" value="1"/>
      <valve id="valve_16" value="0"/>
      <valve flowDirection="1" id="valve_14" value="1"/>
      <valve id="valve_12" value="0"/>
    </decision>
    <decision id="d4">
      <compressorStation flowDirection="0" id="compressorStation_4" value="1"/>
      <valve id="valve_17" value="0"/>
      <valve id="valve_15" value="0"/>
      <valve flowDirection="1" id="valve_16" value="1"/>
      <valve flowDirection="0" id="valve_14" value="1"/>
      <valve id="valve_12" value="0"/>
    </decision>
  </decisionGroup>
  <decisionGroup id="dG_2">
    <decision id="d1_1">
      <compressorStation id="compressorStation_2" value="0"/>
      <compressorStation id="compressorStation_3" value="0"/>
      <compressorStation id="compressorStation_1" value="0"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve id="controlValve_1" value="0"/>
      <valve id="valve_24" value="0"/>
      <valve flowDirection="0" id="valve_7" value="1"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve id="valve_26" value="0"/>
      <valve id="valve_3" value="0"/>
      <valve id="valve_2" value="0"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d1_2">
      <compressorStation id="compressorStation_2" value="0"/>
      <compressorStation id="compressorStation_3" value="0"/>
      <compressorStation id="compressorStation_1" value="0"/>
      <controlValve flowDirection="0" id="controlValve_2" value="1"/>
      <controlValve id="controlValve_1" value="0"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="1" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="0" id="valve_4" value="1"/>
      <valve id="valve_26" value="0"/>
      <valve flowDirection="0" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d1_3">
      <compressorStation id="compressorStation_2" value="0"/>
      <compressorStation id="compressorStation_3" value="0"/>
      <compressorStation id="compressorStation_1" value="0"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve id="valve_24" value="0"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve id="valve_26" value="0"/>
      <valve id="valve_3" value="0"/>
      <valve flowDirection="0" id="valve_2" value="1"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d1_4">
      <compressorStation id="compressorStation_2" value="0"/>
      <compressorStation id="compressorStation_3" value="0"/>
      <compressorStation id="compressorStation_1" value="0"/>
      <controlValve flowDirection="0" id="controlValve_2" value="1"/>
      <controlValve flowDirection="1" id="controlValve_1" value="1"/>
      <valve id="valve_24" value="0"/>
      <valve flowDirection="0" id="valve_7" value="1"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve id="valve_26" value="0"/>
      <valve id="valve_3" value="0"/>
      <valve flowDirection="1" id="valve_2" value="1"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d1_5">
      <compressorStation id="compressorStation_2" value="0"/>
      <compressorStation id="compressorStation_3" value="0"/>
      <compressorStation id="compressorStation_1" value="0"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve id="valve_24" value="0"/>
      <valve flowDirection="0" id="valve_7" value="1"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve id="valve_26" value="0"/>
      <valve id="valve_3" value="0"/>
      <valve flowDirection="0" id="valve_2" value="1"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d2_1_1">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="1" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="0" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve id="valve_3" value="0"/>
      <valve id="valve_2" value="0"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d2_1_2">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation id="compressorStation_1" value="0"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve flowDirection="0" id="valve_6" value="1"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve id="valve_3" value="0"/>
      <valve id="valve_2" value="0"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d2_2_1">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve flowDirection="0" id="controlValve_2" value="1"/>
      <controlValve id="controlValve_1" value="0"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="1" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="0" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve id="valve_3" value="0"/>
      <valve flowDirection="0" id="valve_2" value="1"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d2_2_2">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation id="compressorStation_1" value="0"/>
      <controlValve flowDirection="0" id="controlValve_2" value="1"/>
      <controlValve id="controlValve_1" value="0"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve flowDirection="0" id="valve_6" value="1"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve id="valve_3" value="0"/>
      <valve flowDirection="0" id="valve_2" value="1"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d2_3a_4">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve id="valve_24" value="0"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="0" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="1" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="1" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d2_3b_2s">
      <compressorStation id="compressorStation_2" value="0"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve id="valve_24" value="0"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve flowDirection="0" id="valve_5" value="1"/>
      <valve id="valve_4" value="0"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="1" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d2_4a_4g">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve flowDirection="0" id="controlValve_2" value="1"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="1" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="0" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve id="valve_3" value="0"/>
      <valve flowDirection="1" id="valve_2" value="1"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d2_5a_1_1">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation id="compressorStation_3" value="0"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="1" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d2_5a_1_2">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="1" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="1" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d2_5a_2_1">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="1" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve id="valve_4" value="0"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="1" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d3_4a_1">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve flowDirection="0" id="controlValve_2" value="1"/>
      <controlValve id="controlValve_1" value="0"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve flowDirection="0" id="valve_7" value="1"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="1" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="0" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve id="valve_3" value="0"/>
      <valve flowDirection="1" id="valve_2" value="1"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d3_4b_1">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve flowDirection="0" id="controlValve_2" value="1"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve flowDirection="0" id="valve_24" value="1"/>
      <valve id="valve_7" value="0"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="1" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="0" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="0" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve id="valve_1" value="0"/>
    </decision>
    <decision id="d3_5a_1">
      <compressorStation flowDirection="0" id="compressorStation_2" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve id="valve_24" value="0"/>
      <valve flowDirection="0" id="valve_7" value="1"/>
      <valve id="valve_6" value="0"/>
      <valve flowDirection="0" id="valve_25" value="1"/>
      <valve id="valve_5" value="0"/>
      <valve flowDirection="1" id="valve_4" value="1"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="1" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
    <decision id="d3_5b_2s">
      <compressorStation id="compressorStation_2" value="0"/>
      <compressorStation flowDirection="0" id="compressorStation_3" value="1"/>
      <compressorStation flowDirection="0" id="compressorStation_1" value="1"/>
      <controlValve id="controlValve_2" value="0"/>
      <controlValve flowDirection="0" id="controlValve_1" value="1"/>
      <valve id="valve_24" value="0"/>
      <valve flowDirection="0" id="valve_7" value="1"/>
      <valve id="valve_6" value="0"/>
      <valve id="valve_25" value="0"/>
      <valve flowDirection="0" id="valve_5" value="1"/>
      <valve id="valve_4" value="0"/>
      <valve flowDirection="0" id="valve_26" value="1"/>
      <valve flowDirection="1" id="valve_3" value="1"/>
      <valve id="valve_2" value="0"/>
      <valve flowDirection="1" id="valve_1" value="1"/>
    </decision>
  </decisionGroup>
</combinedDecisions>
