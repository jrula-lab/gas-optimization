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
  <compressorStation id="compressorStation_1">
    <compressors>
      <turboCompressor drive="drive_1" id="compressor_1">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_1">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_1"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_2">
    <compressors>
      <turboCompressor drive="drive_2" id="compressor_2">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_2">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_2"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_3">
    <compressors>
      <turboCompressor drive="drive_3" id="compressor_3">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_3">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_3"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_4">
    <compressors>
      <turboCompressor drive="drive_4" id="compressor_4">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_4">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_4"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_5">
    <compressors>
      <turboCompressor drive="drive_5" id="compressor_5">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_5">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_5"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_6">
    <compressors>
      <turboCompressor drive="drive_6" id="compressor_6">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_6">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_6"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_7">
    <compressors>
      <turboCompressor drive="drive_7" id="compressor_7">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_7">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_7"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_8">
    <compressors>
      <turboCompressor drive="drive_8" id="compressor_8">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_8">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_8"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_9">
    <compressors>
      <turboCompressor drive="drive_9" id="compressor_9">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_9">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_9"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_10">
    <compressors>
      <turboCompressor drive="drive_10" id="compressor_10">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_10">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_10"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_11">
    <compressors>
      <turboCompressor drive="drive_11" id="compressor_11">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_11">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_11"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_12">
    <compressors>
      <turboCompressor drive="drive_12" id="compressor_12">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_12">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_12"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_13">
    <compressors>
      <turboCompressor drive="drive_13" id="compressor_13">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_13">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_13"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_14">
    <compressors>
      <turboCompressor drive="drive_14" id="compressor_14">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_14">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_14"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_15">
    <compressors>
      <turboCompressor drive="drive_15" id="compressor_15">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_15">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_15"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_16">
    <compressors>
      <turboCompressor drive="drive_16" id="compressor_16">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_16">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_16"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_17">
    <compressors>
      <turboCompressor drive="drive_17" id="compressor_17">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_17">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_17"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_18">
    <compressors>
      <turboCompressor drive="drive_18" id="compressor_18">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_18">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_18"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_19">
    <compressors>
      <turboCompressor drive="drive_19" id="compressor_19">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_19">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_19"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_20">
    <compressors>
      <turboCompressor drive="drive_20" id="compressor_20">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_20">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_20"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_21">
    <compressors>
      <turboCompressor drive="drive_21" id="compressor_21">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_21">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_21"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_22">
    <compressors>
      <turboCompressor drive="drive_22" id="compressor_22">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_22">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_22"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_23">
    <compressors>
      <turboCompressor drive="drive_23" id="compressor_23">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_23">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_23"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_24">
    <compressors>
      <turboCompressor drive="drive_24" id="compressor_24">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_24">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_24"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_25">
    <compressors>
      <turboCompressor drive="drive_25" id="compressor_25">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_25">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_25"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_26">
    <compressors>
      <turboCompressor drive="drive_26" id="compressor_26">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_26">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_26"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_27">
    <compressors>
      <turboCompressor drive="drive_27" id="compressor_27">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_27">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_27"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_28">
    <compressors>
      <turboCompressor drive="drive_28" id="compressor_28">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_28">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_28"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_29">
    <compressors>
      <turboCompressor drive="drive_29" id="compressor_29">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.006036379698308192"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.073208950952076"/>
        <n_isoline_coeff_8 value="0.000105700661533296"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8947892693126072"/>
        <eta_ad_isoline_coeff_2 value="-2.253341057317449e-05"/>
        <eta_ad_isoline_coeff_3 value="1.182214108900868e-09"/>
        <eta_ad_isoline_coeff_4 value="0.03138877123712933"/>
        <eta_ad_isoline_coeff_5 value="3.778377088492774e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.560258490628826e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1717399853222829"/>
        <eta_ad_isoline_coeff_8 value="1.266950676067393e-05"/>
        <eta_ad_isoline_coeff_9 value="-1.727197034470033e-10"/>
        <surgeline_coeff_1 value="-30.94688134523292"/>
        <surgeline_coeff_2 value="272.156073693881"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-10.46632784940412"/>
        <chokeline_coeff_2 value="7.562249000768589"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.59"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="20.47020487738303" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1889249999999981" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="26.90461877711645" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2125673674562938" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="33.33619295218352" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2361993007355094" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="39.76530920367905" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.25982220271317" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="46.19234787402536" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2834374709051097" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="52.61768800061644" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3070464980320158" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="59.04170746788208" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3306506725781673" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="65.46478315794197" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354251379344993" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="71.88729110000055" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3778500000000021" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.8525">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="20.00601507708606" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3663450822204236" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="26.2741858805111" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4269444682960139" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="32.52120902764059" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4873394031802379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="38.74971662565079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5475553335438978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="44.96227024911173" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6076170241630661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="51.16136914440477" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6675486372377066" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="57.34945790993469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7273738066423864" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="63.52893372151469" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7871157077798108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="69.70215316518711" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8467971236391291" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="19.1291726329739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5659531764070499" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="25.0724696402147" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6660420747170188" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="30.96028061420153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7651965529680181" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="36.80037527543332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8635474581905711" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="42.59999036872001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9612166617659149" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="48.36591257930557" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.058318455786203" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="54.10454967791574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.154960751182317" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="59.8219922080452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.251246116576986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="65.52406755726383" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.347272688879937" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8574999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="17.74236983794058" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7839817146163875" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="23.19169976175959" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9233701770458311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="28.54427147511718" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.060283660281101" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="33.81611720672514" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.195132252854308" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="39.02134093789905" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.328276720638909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="44.17251996563981" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.460038778435619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="49.28101719951554" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.590709078217353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="54.35722856560967" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.72055353747719" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="59.41078260969829" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.84981844487996" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="15.79755182795018" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.01359780284915" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="20.61064928503335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.189074851399177" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="25.29328705588077" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.359795569768994" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="29.87091837530004" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.526687938029631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="34.36464014938683" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.690521112186801" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="38.79233425254283" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.851947033858253" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="43.16947448461902" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.011529850508674" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="47.50971423291951" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.169767340570392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="51.82532636064705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.327106951000649" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7925">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="13.32090439203854" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.246196236238013" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="17.41299043742607" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.452334628146348" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="21.35914762504166" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.651121869629086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="25.19191590830036" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.844197157319767" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="28.93687388769419" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.032849010451419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="32.6147821453814" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.218123241104657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="36.24297976842691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400893303914863" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="39.83633321117154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.581908094911397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="43.40790544748323" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.761825659989876" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.725">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.40849062778388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.473469815648566" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.7595300484919" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.704046166472448" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.96872560819623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924862608279776" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.07102552085703" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.138323837235251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.09277944020616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.346242904825353" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.05468526187855" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.550043979687354" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.97359139556509" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.750886357292297" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.86365946176045" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.949744462099422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.73714960632432" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.14746188301891" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6575">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="7.195578172732366" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.689081721201597" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.836099862164206" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.938292964182131" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="12.3529314287409" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.1758303893014" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="14.77880877379909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.404783596124083" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.13768816678856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.627413566527607" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="19.44796960422069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.845456883862068" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="21.72438104968843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.060303566671251" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="23.97915106519729" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.273107741107367" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="26.22277809771928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.48486024584814" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.59">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.820651075297946" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.810077617226454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.152323398102379" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="7.701058696231229" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.402378782262909" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="9.521008160878843" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.643041244509609" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="11.28959565139259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.876911815332389" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.02171586806259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.105960107248452" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="14.72917240692462" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.331746978150016" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.4217012753493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.555559876700787" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.10763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.7785" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_29">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1164.594258777371"/>
        <power_fun_coeff_2 value="2.555634634291757"/>
        <power_fun_coeff_3 value="-0.000104977631291941"/>
        <power_fun_coeff_4 value="7.005733212792697"/>
        <power_fun_coeff_5 value="-0.01537367568342418"/>
        <power_fun_coeff_6 value="6.315034378705861e-07"/>
        <power_fun_coeff_7 value="-0.02328473640875715"/>
        <power_fun_coeff_8 value="5.109700513125207e-05"/>
        <power_fun_coeff_9 value="-2.098908229218584e-09"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="7000" id="compressor_29"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
</compressorStations>
