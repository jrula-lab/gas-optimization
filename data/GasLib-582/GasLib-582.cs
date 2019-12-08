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
  <compressorStation id="compressorStation_5">
    <compressors>
      <turboCompressor drive="drive_1" id="compressor_1">
        <speedMin value="4700" unit="per_min"/>
        <speedMax value="6500" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.01354692769230769"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-5.373431349512686"/>
        <n_isoline_coeff_8 value="0.0002066704365197187"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8557230655873604"/>
        <eta_ad_isoline_coeff_2 value="-1.865346607990314e-05"/>
        <eta_ad_isoline_coeff_3 value="4.839959819984892e-10"/>
        <eta_ad_isoline_coeff_4 value="0.06289792959218318"/>
        <eta_ad_isoline_coeff_5 value="2.000177353705445e-05"/>
        <eta_ad_isoline_coeff_6 value="-1.464385249952582e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.1075991039762094"/>
        <eta_ad_isoline_coeff_8 value="1.258629719797824e-05"/>
        <eta_ad_isoline_coeff_9 value="-5.168503443472956e-10"/>
        <surgeline_coeff_1 value="39.58581608288462"/>
        <surgeline_coeff_2 value="118.1018284926642"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-42.55415413593948"/>
        <chokeline_coeff_2 value="15.95017703019676"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.5"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="4700" unit="per_min"/>
            <adiabaticHead value="63.49021667894237" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2024050000000004" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4925" unit="per_min"/>
            <adiabaticHead value="66.49254289757492" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2278265049584866" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5150" unit="per_min"/>
            <adiabaticHead value="69.49039937388068" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2532101634044857" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5375" unit="per_min"/>
            <adiabaticHead value="72.48398432600297" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.2785576537044198" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5600" unit="per_min"/>
            <adiabaticHead value="75.4734936550978" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3038706346061552" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5825" unit="per_min"/>
            <adiabaticHead value="78.45912104684025" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.329150746098484" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6050" unit="per_min"/>
            <adiabaticHead value="81.44105807006289" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.354399610246323" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6275" unit="per_min"/>
            <adiabaticHead value="84.4194942726742" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3796188320028794" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6500" unit="per_min"/>
            <adiabaticHead value="87.39461727499994" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.4048099999999994" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.82">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="61.83766414686008" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6452677091535403" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="64.70064134496027" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6806677810494035" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="67.55764006851864" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7159939304464255" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="70.40903250320851" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7512507593371069" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="73.25518415455181" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7864427871153723" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="76.09645424001459" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8215744554247428" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="78.9331960642499" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.856650132798132" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="81.76575737867688" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8916741191039588" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="84.5944807265016" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9266506498122543" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.82">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="58.32225867048776" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.102247087903595" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="60.9888268371932" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.146955214275252" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="63.64867752883188" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.191550714340208" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="66.30236203897616" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.236042831178392" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="68.95041852583611" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.280440587640059" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="71.59337296792165" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.324752802368581" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="74.23174006532719" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.368988104911537" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="76.86602409142974" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.413154950000422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="79.49671969936608" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.457261631072181" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.82">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="53.00998945735877" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.556185080001534" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="55.44086537237096" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.609119616029183" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="57.86521195727046" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.66191196994957" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="60.2837178523647" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.714577137532303" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="62.69705214849023" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.767129688839462" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="65.10586605893003" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.819583804633125" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="67.51079447710146" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.871953310295438" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="69.9124574318033" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.924251707517945" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="72.31146145056783" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.976492203989821" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.82">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="46.19789484096017" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.992281026436416" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="48.3748044580359" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.052210257923613" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="50.54611138382691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.111985250125761" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="52.71257536216135" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.171626918409944" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="54.87493244196659" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.231155525834494" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="57.03389727234602" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.290590746331306" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="59.19016522207542" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.349951723054512" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="61.34441434375704" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.409257122452661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="63.49730720048645" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.46852518455594" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.74">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="38.30480921235791" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.400462257068086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="40.22705518808978" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.46621438660701" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="42.14500701064763" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.531819630825678" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="44.05943225246709" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.597304245220449" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="45.97107370987585" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.662693637798922" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="47.8806520551727" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.728012459796653" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="49.78886827248949" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.793284688997976" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="51.69640590435654" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.858533706581765" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="53.60393313250069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.923782368296979" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6599999999999999">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="29.75712203281513" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.775600327992834" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="31.43547258706537" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.846168990908225" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="33.11089534441114" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.91661455039191" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="34.7841200373534" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.986967689096416" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="36.45585304641067" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.057258107806586" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="38.12678012252209" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.127514639906928" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="39.79756888097302" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.197765356242301" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="41.46887109690248" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.268037661635831" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="43.14132482851024" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.338358384162204" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.58">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="20.91749529065253" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.116410412545192" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="22.36864445055645" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.190977315851446" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="23.8180855450251" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.265456450681741" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="25.26648382103686" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.339882000570399" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="26.71448405766332" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.414287097313938" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="28.16271314575159" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.488703953527349" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="29.61178245005025" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.563163984021287" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="31.06228998360329" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.637697917532714" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="32.51482242025042" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.712335900136675" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.5">
            <measurement>
              <speed value="4700" unit="per_min"/>
              <adiabaticHead value="12.06004952430573" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.42405" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4925" unit="per_min"/>
              <adiabaticHead value="13.30281966870856" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.501965758680925" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5150" unit="per_min"/>
              <adiabaticHead value="14.54486332647365" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.579835970115798" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5375" unit="per_min"/>
              <adiabaticHead value="15.786769002429" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.657697530749526" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5600" unit="per_min"/>
              <adiabaticHead value="17.02910816896097" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.735586269174183" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5825" unit="per_min"/>
              <adiabaticHead value="18.27243758089542" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.813537091261022" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6050" unit="per_min"/>
              <adiabaticHead value="19.51730139747079" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.891584113198058" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6275" unit="per_min"/>
              <adiabaticHead value="20.76423313873178" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.969760784146619" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6500" unit="per_min"/>
              <adiabaticHead value="22.01375750000001" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.0481" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
      <pistonCompressor drive="drive_2" id="compressor_2">
        <speedMin unit="per_min" value="165"/>
        <speedMax unit="per_min" value="350"/>
        <operatingVolume unit="m_cube" value="0.5"/>
        <maximalTorque unit="kNm" value="0"/>
        <maximalCompressionRatio value="2"/>
        <adiabaticEfficiency value="0.95"/>
        <additionalReductionVolFlow value="0.35"/>
      </pistonCompressor>
    </compressors>
    <drives>
      <gasTurbine id="drive_1">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-1491.908293840061"/>
        <power_fun_coeff_2 value="6.043631071281657"/>
        <power_fun_coeff_3 value="-0.0004582765616724116"/>
        <power_fun_coeff_4 value="8.97472351921858"/>
        <power_fun_coeff_5 value="-0.03635606701890647"/>
        <power_fun_coeff_6 value="2.756808480340104e-06"/>
        <power_fun_coeff_7 value="-0.02982900791952576"/>
        <power_fun_coeff_8 value="0.000120835523089651"/>
        <power_fun_coeff_9 value="-9.162718140184072e-09"/>
      </gasTurbine>
      <gasDrivenMotor id="drive_2">
        <energy_rate_fun_coeff_1 value="2629"/>
        <energy_rate_fun_coeff_2 value="2.47429"/>
        <energy_rate_fun_coeff_3 value="1.37143e-05"/>
        <power_fun_coeff_1 value="230.515"/>
        <power_fun_coeff_2 value="24.4196"/>
        <power_fun_coeff_3 value="0.00423351"/>
        <specificEnergyConsumptionMeasurements>
          <measurement>
            <compressorPower unit="kW" value="5250"/>
            <fuelConsumption unit="kW" value="15997"/>
          </measurement>
          <measurement>
            <compressorPower unit="kW" value="7000"/>
            <fuelConsumption unit="kW" value="20621"/>
          </measurement>
          <measurement>
            <compressorPower unit="kW" value="8750"/>
            <fuelConsumption unit="kW" value="25329"/>
          </measurement>
        </specificEnergyConsumptionMeasurements>
        <maximalPowerMeasurements>
          <measurement>
            <speed unit="per_min" value="165"/>
            <maximalPower unit="kW" value="4375"/>
          </measurement>
          <measurement>
            <speed unit="per_min" value="250"/>
            <maximalPower unit="kW" value="6600"/>
          </measurement>
          <measurement>
            <speed unit="per_min" value="330"/>
            <maximalPower unit="kW" value="8750"/>
          </measurement>
        </maximalPowerMeasurements>
      </gasDrivenMotor>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="350" id="compressor_2"/>
        </stage>
      </configuration>
      <configuration nrOfSerialStages="1" confId="config_2">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="6500" id="compressor_1"/>
        </stage>
      </configuration>
      <configuration nrOfSerialStages="1" confId="config_3">
        <stage nrOfParallelUnits="2" stageNr="1">
          <compressor nominalSpeed="350" id="compressor_2"/>
          <compressor nominalSpeed="6500" id="compressor_1"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_2">
    <compressors>
      <turboCompressor drive="drive_3" id="compressor_3">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.003152688557379781"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-0.6859136552635909"/>
        <n_isoline_coeff_8 value="1.429105873955311e-05"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.9124877542087437"/>
        <eta_ad_isoline_coeff_2 value="-3.208902037274044e-05"/>
        <eta_ad_isoline_coeff_3 value="1.68625518540633e-09"/>
        <eta_ad_isoline_coeff_4 value="0.02861500814991246"/>
        <eta_ad_isoline_coeff_5 value="2.669256978546698e-05"/>
        <eta_ad_isoline_coeff_6 value="-1.829102559553304e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.06376551939674266"/>
        <eta_ad_isoline_coeff_8 value="4.755481242710625e-06"/>
        <eta_ad_isoline_coeff_9 value="-6.7526314631729e-11"/>
        <surgeline_coeff_1 value="-16.16297906691495"/>
        <surgeline_coeff_2 value="72.32086979143992"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-5.466367872426867"/>
        <chokeline_coeff_2 value="2.009539665575093"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.49"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="10.69120630404223" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3713199999999959" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="14.05178070277028" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.4177875605868546" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="17.41087196625689" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.4642346134662463" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="20.76867950209375" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.5106639159002485" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="24.1254019560373" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.5570782146168392" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="27.48123729224881" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6034802469193975" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="30.83638287272257" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6498727417849789" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="34.19103553595811" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6962584209521369" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="37.54539167499942" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.742639999999992" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.44876862699238" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.720027820193661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.72251735641691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.839132036351335" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.98522105929388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9578344167732472" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.23825443612125" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.076184975262775" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.48295534953188" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.19423238540283" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.72062910930769" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.312024136451529" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="29.95255248361168" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.429606679277229" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="33.17997747267162" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.547025563651182" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="36.40413487743452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.664325568080889" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="9.990810168721127" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.112344758308671" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.09488337224893" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.309063084207615" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.16997725524399" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.503944867265233" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="19.22014979784273" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.697247278948378" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="22.24918061691739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88920984965949" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="25.26061427162107" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.080057213193241" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.25779742111941" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.270001461580086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.2439110427108" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.459244186885624" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.22199867226091" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.647978270927081" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.865">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="9.266508928282391" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.540865900602657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="12.1125923350347" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.814825005375986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="14.90814073269211" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.083919696893363" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="17.66152745536133" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.348955977927018" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="20.38011874948966" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.610642910719279" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="23.07048350277458" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.869612805127506" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="25.73855635100183" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.12643691900843" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="28.38976689251424" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.381637896181184" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="31.02914393722928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.635699801258844" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.87">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="8.25076674625873" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.992161631091419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="10.764557799322" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.337050542922019" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="13.21021219091743" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.672591192095397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="15.6010236709642" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.000607464068612" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.94801076012667" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.322611085759973" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="20.26051282796546" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.639883406707668" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="22.54661155160623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.953533222659154" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="24.81343784064614" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.264538885275098" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="27.06740158268664" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.573779822922119" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.775">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="6.957259971982926" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.449318970172814" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.094480209259011" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.854470790648681" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="11.15548452522416" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.245174395292695" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="13.15726793078172" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.624651520211596" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="15.1131896520101" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.995434667517908" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="17.03409255385256" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.35957931394459" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="18.92903251816493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.718802178693486" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="20.80577401683794" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.074575168995631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="22.67113959754041" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.428191631956813" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6799999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="5.436160570052593" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.896010649446212" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="7.186345973392228" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.349193714619819" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="8.862448973060971" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.783194303064424" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="10.48272236953853" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.202738691238286" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="12.06092809563286" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.611390315838295" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.60787627628495" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.011948289202108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="15.13236652170778" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.406691132405854" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.64179518221707" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.797534014380084" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.14256550338309" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.186134955154594" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.585">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.758116305252145" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.319782054871388" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.137211546414337" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.809590808310752" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="6.451705742831846" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.276455419639519" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="7.718696245353625" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.726448299128196" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="8.950694966806017" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.164013261998311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="10.15731188226622" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.592563451717155" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="11.34623913248971" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.014830860798565" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="12.52386346738868" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.433083850353246" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="13.69566803005436" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.849269850407999" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.49">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="1.995454813786563" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.713199999999999" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="3.034495200235998" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.230253932424906" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="4.022119357091286" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.721721791345048" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="4.972645026278748" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.194728463206605" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="5.896345294111542" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.654386107022483" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="6.800999384812989" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.104565870178615" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="7.692772096493522" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.548335518997826" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="8.576748364257622" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.988225451457119" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="9.457277500000002" unit="kJ_per_kg"/>
              <volumetricFlowrate value="7.426400000000001" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
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
      <gasTurbine id="drive_3">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-17778.43992498299"/>
        <power_fun_coeff_2 value="39.01375648516525"/>
        <power_fun_coeff_3 value="-0.001602565440559642"/>
        <power_fun_coeff_4 value="106.947983055361"/>
        <power_fun_coeff_5 value="-0.2346911531668281"/>
        <power_fun_coeff_6 value="9.640392650045403e-06"/>
        <power_fun_coeff_7 value="-0.3554596669974558"/>
        <power_fun_coeff_8 value="0.0007800356469438608"/>
        <power_fun_coeff_9 value="-3.204147159405531e-08"/>
      </gasTurbine>
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
          <compressor nominalSpeed="11000" id="compressor_3"/>
        </stage>
      </configuration>
      <configuration nrOfSerialStages="1" confId="config_2">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="11000" id="compressor_4"/>
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
        <n_isoline_coeff_2 value="0.003152688557379781"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-0.6859136552635909"/>
        <n_isoline_coeff_8 value="1.429105873955311e-05"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.9124877542087437"/>
        <eta_ad_isoline_coeff_2 value="-3.208902037274044e-05"/>
        <eta_ad_isoline_coeff_3 value="1.68625518540633e-09"/>
        <eta_ad_isoline_coeff_4 value="0.02861500814991246"/>
        <eta_ad_isoline_coeff_5 value="2.669256978546698e-05"/>
        <eta_ad_isoline_coeff_6 value="-1.829102559553304e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.06376551939674266"/>
        <eta_ad_isoline_coeff_8 value="4.755481242710625e-06"/>
        <eta_ad_isoline_coeff_9 value="-6.7526314631729e-11"/>
        <surgeline_coeff_1 value="-16.16297906691495"/>
        <surgeline_coeff_2 value="72.32086979143992"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-5.466367872426867"/>
        <chokeline_coeff_2 value="2.009539665575093"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.49"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="10.69120630404223" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3713199999999959" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="14.05178070277028" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.4177875605868546" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="17.41087196625689" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.4642346134662463" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="20.76867950209375" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.5106639159002485" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="24.1254019560373" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.5570782146168392" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="27.48123729224881" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6034802469193975" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="30.83638287272257" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6498727417849789" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="34.19103553595811" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6962584209521369" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="37.54539167499942" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.742639999999992" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.44876862699238" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.720027820193661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.72251735641691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.839132036351335" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.98522105929388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9578344167732472" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.23825443612125" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.076184975262775" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.48295534953188" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.19423238540283" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.72062910930769" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.312024136451529" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="29.95255248361168" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.429606679277229" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="33.17997747267162" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.547025563651182" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="36.40413487743452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.664325568080889" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="9.990810168721127" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.112344758308671" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.09488337224893" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.309063084207615" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.16997725524399" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.503944867265233" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="19.22014979784273" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.697247278948378" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="22.24918061691739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88920984965949" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="25.26061427162107" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.080057213193241" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.25779742111941" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.270001461580086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.2439110427108" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.459244186885624" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.22199867226091" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.647978270927081" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.865">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="9.266508928282391" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.540865900602657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="12.1125923350347" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.814825005375986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="14.90814073269211" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.083919696893363" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="17.66152745536133" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.348955977927018" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="20.38011874948966" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.610642910719279" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="23.07048350277458" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.869612805127506" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="25.73855635100183" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.12643691900843" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="28.38976689251424" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.381637896181184" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="31.02914393722928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.635699801258844" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.87">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="8.25076674625873" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.992161631091419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="10.764557799322" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.337050542922019" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="13.21021219091743" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.672591192095397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="15.6010236709642" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.000607464068612" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.94801076012667" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.322611085759973" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="20.26051282796546" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.639883406707668" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="22.54661155160623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.953533222659154" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="24.81343784064614" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.264538885275098" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="27.06740158268664" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.573779822922119" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.775">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="6.957259971982926" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.449318970172814" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.094480209259011" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.854470790648681" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="11.15548452522416" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.245174395292695" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="13.15726793078172" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.624651520211596" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="15.1131896520101" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.995434667517908" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="17.03409255385256" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.35957931394459" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="18.92903251816493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.718802178693486" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="20.80577401683794" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.074575168995631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="22.67113959754041" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.428191631956813" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6799999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="5.436160570052593" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.896010649446212" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="7.186345973392228" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.349193714619819" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="8.862448973060971" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.783194303064424" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="10.48272236953853" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.202738691238286" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="12.06092809563286" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.611390315838295" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.60787627628495" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.011948289202108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="15.13236652170778" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.406691132405854" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.64179518221707" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.797534014380084" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.14256550338309" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.186134955154594" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.585">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.758116305252145" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.319782054871388" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.137211546414337" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.809590808310752" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="6.451705742831846" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.276455419639519" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="7.718696245353625" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.726448299128196" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="8.950694966806017" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.164013261998311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="10.15731188226622" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.592563451717155" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="11.34623913248971" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.014830860798565" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="12.52386346738868" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.433083850353246" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="13.69566803005436" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.849269850407999" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.49">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="1.995454813786563" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.713199999999999" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="3.034495200235998" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.230253932424906" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="4.022119357091286" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.721721791345048" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="4.972645026278748" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.194728463206605" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="5.896345294111542" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.654386107022483" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="6.800999384812989" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.104565870178615" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="7.692772096493522" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.548335518997826" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="8.576748364257622" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.988225451457119" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="9.457277500000002" unit="kJ_per_kg"/>
              <volumetricFlowrate value="7.426400000000001" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
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
      <gasTurbine id="drive_3">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-17778.43992498299"/>
        <power_fun_coeff_2 value="39.01375648516525"/>
        <power_fun_coeff_3 value="-0.001602565440559642"/>
        <power_fun_coeff_4 value="106.947983055361"/>
        <power_fun_coeff_5 value="-0.2346911531668281"/>
        <power_fun_coeff_6 value="9.640392650045403e-06"/>
        <power_fun_coeff_7 value="-0.3554596669974558"/>
        <power_fun_coeff_8 value="0.0007800356469438608"/>
        <power_fun_coeff_9 value="-3.204147159405531e-08"/>
      </gasTurbine>
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
          <compressor nominalSpeed="11000" id="compressor_3"/>
        </stage>
      </configuration>
      <configuration nrOfSerialStages="1" confId="config_2">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="11000" id="compressor_4"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_1">
    <compressors>
      <turboCompressor drive="drive_3" id="compressor_3">
        <speedMin value="3419" unit="per_min"/>
        <speedMax value="11999" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.003152688557379781"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-0.6859136552635909"/>
        <n_isoline_coeff_8 value="1.429105873955311e-05"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.9124877542087437"/>
        <eta_ad_isoline_coeff_2 value="-3.208902037274044e-05"/>
        <eta_ad_isoline_coeff_3 value="1.68625518540633e-09"/>
        <eta_ad_isoline_coeff_4 value="0.02861500814991246"/>
        <eta_ad_isoline_coeff_5 value="2.669256978546698e-05"/>
        <eta_ad_isoline_coeff_6 value="-1.829102559553304e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.06376551939674266"/>
        <eta_ad_isoline_coeff_8 value="4.755481242710625e-06"/>
        <eta_ad_isoline_coeff_9 value="-6.7526314631729e-11"/>
        <surgeline_coeff_1 value="-16.16297906691495"/>
        <surgeline_coeff_2 value="72.32086979143992"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-5.466367872426867"/>
        <chokeline_coeff_2 value="2.009539665575093"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.49"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="3419" unit="per_min"/>
            <adiabaticHead value="10.69120630404223" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.3713199999999959" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="4491.5" unit="per_min"/>
            <adiabaticHead value="14.05178070277028" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.4177875605868546" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="5564" unit="per_min"/>
            <adiabaticHead value="17.41087196625689" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.4642346134662463" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6636.5" unit="per_min"/>
            <adiabaticHead value="20.76867950209375" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.5106639159002485" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7708.999999999999" unit="per_min"/>
            <adiabaticHead value="24.1254019560373" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.5570782146168392" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8781.5" unit="per_min"/>
            <adiabaticHead value="27.48123729224881" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6034802469193975" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9854" unit="per_min"/>
            <adiabaticHead value="30.83638287272257" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6498727417849789" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10926.5" unit="per_min"/>
            <adiabaticHead value="34.19103553595811" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.6962584209521369" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="11999" unit="per_min"/>
            <adiabaticHead value="37.54539167499942" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.742639999999992" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.855">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="10.44876862699238" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.720027820193661" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.72251735641691" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.839132036351335" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.98522105929388" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9578344167732472" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="20.23825443612125" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.076184975262775" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="23.48295534953188" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.19423238540283" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="26.72062910930769" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.312024136451529" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="29.95255248361168" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.429606679277229" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="33.17997747267162" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.547025563651182" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="36.40413487743452" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.664325568080889" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.86">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="9.990810168721127" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.112344758308671" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="13.09488337224893" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.309063084207615" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="16.16997725524399" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.503944867265233" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="19.22014979784273" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.697247278948378" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="22.24918061691739" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.88920984965949" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="25.26061427162107" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.080057213193241" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="28.25779742111941" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.270001461580086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="31.2439110427108" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.459244186885624" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="34.22199867226091" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.647978270927081" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.865">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="9.266508928282391" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.540865900602657" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="12.1125923350347" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.814825005375986" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="14.90814073269211" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.083919696893363" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="17.66152745536133" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.348955977927018" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="20.38011874948966" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.610642910719279" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="23.07048350277458" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.869612805127506" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="25.73855635100183" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.12643691900843" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="28.38976689251424" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.381637896181184" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="31.02914393722928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.635699801258844" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.87">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="8.25076674625873" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.992161631091419" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="10.764557799322" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.337050542922019" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="13.21021219091743" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.672591192095397" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="15.6010236709642" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.000607464068612" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="17.94801076012667" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.322611085759973" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="20.26051282796546" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.639883406707668" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="22.54661155160623" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.953533222659154" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="24.81343784064614" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.264538885275098" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="27.06740158268664" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.573779822922119" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.775">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="6.957259971982926" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.449318970172814" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="9.094480209259011" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.854470790648681" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="11.15548452522416" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.245174395292695" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="13.15726793078172" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.624651520211596" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="15.1131896520101" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.995434667517908" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="17.03409255385256" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.35957931394459" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="18.92903251816493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.718802178693486" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="20.80577401683794" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.074575168995631" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="22.67113959754041" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.428191631956813" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6799999999999999">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="5.436160570052593" unit="kJ_per_kg"/>
              <volumetricFlowrate value="2.896010649446212" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="7.186345973392228" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.349193714619819" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="8.862448973060971" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.783194303064424" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="10.48272236953853" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.202738691238286" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="12.06092809563286" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.611390315838295" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="13.60787627628495" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.011948289202108" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="15.13236652170778" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.406691132405854" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="16.64179518221707" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.797534014380084" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="18.14256550338309" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.186134955154594" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.585">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="3.758116305252145" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.319782054871388" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="5.137211546414337" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.809590808310752" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="6.451705742831846" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.276455419639519" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="7.718696245353625" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.726448299128196" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="8.950694966806017" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.164013261998311" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="10.15731188226622" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.592563451717155" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="11.34623913248971" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.014830860798565" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="12.52386346738868" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.433083850353246" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="13.69566803005436" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.849269850407999" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.49">
            <measurement>
              <speed value="3419" unit="per_min"/>
              <adiabaticHead value="1.995454813786563" unit="kJ_per_kg"/>
              <volumetricFlowrate value="3.713199999999999" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="4491.5" unit="per_min"/>
              <adiabaticHead value="3.034495200235998" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.230253932424906" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="5564" unit="per_min"/>
              <adiabaticHead value="4.022119357091286" unit="kJ_per_kg"/>
              <volumetricFlowrate value="4.721721791345048" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6636.5" unit="per_min"/>
              <adiabaticHead value="4.972645026278748" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.194728463206605" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7708.999999999999" unit="per_min"/>
              <adiabaticHead value="5.896345294111542" unit="kJ_per_kg"/>
              <volumetricFlowrate value="5.654386107022483" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8781.5" unit="per_min"/>
              <adiabaticHead value="6.800999384812989" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.104565870178615" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9854" unit="per_min"/>
              <adiabaticHead value="7.692772096493522" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.548335518997826" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10926.5" unit="per_min"/>
              <adiabaticHead value="8.576748364257622" unit="kJ_per_kg"/>
              <volumetricFlowrate value="6.988225451457119" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="11999" unit="per_min"/>
              <adiabaticHead value="9.457277500000002" unit="kJ_per_kg"/>
              <volumetricFlowrate value="7.426400000000001" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
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
      <gasTurbine id="drive_3">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-17778.43992498299"/>
        <power_fun_coeff_2 value="39.01375648516525"/>
        <power_fun_coeff_3 value="-0.001602565440559642"/>
        <power_fun_coeff_4 value="106.947983055361"/>
        <power_fun_coeff_5 value="-0.2346911531668281"/>
        <power_fun_coeff_6 value="9.640392650045403e-06"/>
        <power_fun_coeff_7 value="-0.3554596669974558"/>
        <power_fun_coeff_8 value="0.0007800356469438608"/>
        <power_fun_coeff_9 value="-3.204147159405531e-08"/>
      </gasTurbine>
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
          <compressor nominalSpeed="11000" id="compressor_3"/>
        </stage>
      </configuration>
      <configuration nrOfSerialStages="1" confId="config_2">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="11000" id="compressor_4"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
  <compressorStation id="compressorStation_4">
    <compressors>
      <turboCompressor drive="drive_5" id="compressor_5">
        <speedMin value="6174" unit="per_min"/>
        <speedMax value="10805" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.004066823692734845"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-65.35102617489591"/>
        <n_isoline_coeff_8 value="0.001512055209969827"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.7846892496487685"/>
        <eta_ad_isoline_coeff_2 value="-1.313057874880348e-05"/>
        <eta_ad_isoline_coeff_3 value="5.6901699944729e-10"/>
        <eta_ad_isoline_coeff_4 value="0.2605487884207887"/>
        <eta_ad_isoline_coeff_5 value="5.692157645287694e-05"/>
        <eta_ad_isoline_coeff_6 value="-4.044085600615189e-09"/>
        <eta_ad_isoline_coeff_7 value="-2.457163953593287"/>
        <eta_ad_isoline_coeff_8 value="0.0002497031090145517"/>
        <eta_ad_isoline_coeff_9 value="-7.60623144245617e-09"/>
        <surgeline_coeff_1 value="6.416349744738547"/>
        <surgeline_coeff_2 value="453.6111589056275"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="0.1254611294177064"/>
        <chokeline_coeff_2 value="13.243958988515"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.6"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="6174" unit="per_min"/>
            <adiabaticHead value="25.01440725986929" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.04100000000000004" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6752.875" unit="per_min"/>
            <adiabaticHead value="27.34537057632119" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.04613868160138641" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7331.75" unit="per_min"/>
            <adiabaticHead value="29.67427714755834" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.05127282904356093" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7910.625" unit="per_min"/>
            <adiabaticHead value="32.00126998880229" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.0564027576080566" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8489.5" unit="per_min"/>
            <adiabaticHead value="34.3264910801378" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.06152878029441484" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9068.375" unit="per_min"/>
            <adiabaticHead value="36.65008142881666" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.0666512079575365" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9647.25" unit="per_min"/>
            <adiabaticHead value="38.97218113038544" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.07177034944243962" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10226.125" unit="per_min"/>
            <adiabaticHead value="41.29292942871464" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.07688651171659572" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10805" unit="per_min"/>
            <adiabaticHead value="43.612464775" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.082" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.75375">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="24.51717502627574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.102750545824058" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="26.75368272770285" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1133991394744793" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="28.98241177029779" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1240106969112555" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="31.20401477977997" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1345883254548252" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="33.41912618098717" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1451350457665056" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="35.62836372819994" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.155653799134764" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="37.83232993717234" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.166147454293488" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="40.03161342892493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1766188138201328" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="42.22679019435684" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.187070620156867" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7575000000000001">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="23.45801331141876" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1716566640269351" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="25.51550305237024" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1879213641969808" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="27.55727326911857" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2040617996657785" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="29.58492509712909" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2200906275988815" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="31.59996594074605" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2360197642062259" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="33.60382055741304" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2518604723642059" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="35.59784081307102" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2676234387332517" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="37.58331431602154" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2833188420095405" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="39.56147210111622" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2989564136694253" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.76125">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="21.75697855803089" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.244608202921919" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="23.56091653311778" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.266011180911434" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="25.3425287674458" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2871492732204762" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="27.1045483973032" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3080549073807166" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="28.84945942341228" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3287575550333756" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="30.57953548659864" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3492841919865008" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="32.29687195826264" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3696596789551398" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="34.0034127535251" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3899070796882237" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="35.70097294347582" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4100479292535432" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.765">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="19.45664948616255" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3176460923542582" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="20.96463544562355" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3432884269427309" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="22.44781104071613" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3685088771891077" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="23.90970252573334" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3933674047872356" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="25.35341770106617" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4179168558905947" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="26.7817246340513" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4422042997098534" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="28.19711352013908" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4662720804223748" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="29.60184598635259" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4901586555459337" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="30.9979949111773" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5138992730504151" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.72375">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="16.70693228827276" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3872821459029937" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="17.91300152436556" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4161610453342658" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="19.09592630263604" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.444485758944492" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="20.25938208130346" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.472344294275115" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="21.40653628606031" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4998124942091899" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="22.54015604781398" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5269566167133376" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="23.66268973245601" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5538352870391082" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="24.7763297699805" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5805010021439028" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="25.88306189105253" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6070013096431137" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6825">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="13.69851114035533" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.451325058174287" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="14.62202670988123" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.482569857029534" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="15.52652618772202" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.513171294820474" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="16.4152836096256" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5432401402138883" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="17.29108066511574" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.572870504595135" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="18.15631891487493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6021436386576934" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="19.0131026510335" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6311307357701592" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="19.86330139308707" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6598950463665522" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="20.70859794627216" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6884935038791422" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.64125">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="10.60211138651526" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5088926849737797" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="11.27386791567235" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5418435026112606" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="11.93152250336153" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5741025956707503" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="12.57765466615091" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6057964938938146" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="13.2144389199561" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.637031861040722" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="13.8437410556678" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6679002173762124" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="14.46718820056756" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6984813763029099" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="15.0862210028205" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7288460041007967" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="15.70213333031993" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7590575672240837" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="7.542078162986104" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5599999999999999" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="7.994877272904822" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.594189105411107" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="8.438275669298552" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6276683993879487" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="8.874077232716136" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6605740859576147" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="9.303797326591365" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6930205843383388" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="9.728733039270436" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7251058326426842" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="10.15001390379455" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7569151175316997" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="10.56863942962963" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7885239080903315" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="10.9855075" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.82" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
        </characteristicDiagramMeasurements>
      </turboCompressor>
      <turboCompressor drive="drive_6" id="compressor_6">
        <speedMin value="6174" unit="per_min"/>
        <speedMax value="10805" unit="per_min"/>
        <n_isoline_coeff_1 value="0"/>
        <n_isoline_coeff_2 value="0.004501245719574271"/>
        <n_isoline_coeff_3 value="0"/>
        <n_isoline_coeff_4 value="0"/>
        <n_isoline_coeff_5 value="0"/>
        <n_isoline_coeff_6 value="0"/>
        <n_isoline_coeff_7 value="-19.65622194946589"/>
        <n_isoline_coeff_8 value="0.0004547945846706593"/>
        <n_isoline_coeff_9 value="0"/>
        <eta_ad_isoline_coeff_1 value="0.8406181992830516"/>
        <eta_ad_isoline_coeff_2 value="-1.616552120807179e-05"/>
        <eta_ad_isoline_coeff_3 value="6.854505104751231e-10"/>
        <eta_ad_isoline_coeff_4 value="0.1981674103167527"/>
        <eta_ad_isoline_coeff_5 value="3.451167451844545e-05"/>
        <eta_ad_isoline_coeff_6 value="-2.49747316294417e-09"/>
        <eta_ad_isoline_coeff_7 value="-0.8642147298364616"/>
        <eta_ad_isoline_coeff_8 value="8.692508222534989e-05"/>
        <eta_ad_isoline_coeff_9 value="-2.648337894565158e-09"/>
        <surgeline_coeff_1 value="7.101750409143911"/>
        <surgeline_coeff_2 value="261.7256191408525"/>
        <surgeline_coeff_3 value="0"/>
        <chokeline_coeff_1 value="-1.606592784373927"/>
        <chokeline_coeff_2 value="8.751165152176688"/>
        <chokeline_coeff_3 value="0"/>
        <efficiencyOfChokeline value="0.6"/>
        <surgelineMeasurements>
          <measurement>
            <speed value="6174" unit="per_min"/>
            <adiabaticHead value="27.68647035457171" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.07864999999999907" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="6752.875" unit="per_min"/>
            <adiabaticHead value="30.26642941928565" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.08850749531583012" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7331.75" unit="per_min"/>
            <adiabaticHead value="32.84411203527821" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.0983562927872207" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="7910.625" unit="per_min"/>
            <adiabaticHead value="35.41967649479533" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1081969972164307" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="8489.5" unit="per_min"/>
            <adiabaticHead value="37.9932799443707" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1180302090281882" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9068.375" unit="per_min"/>
            <adiabaticHead value="40.56507845378679" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1278565245331752" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="9647.25" unit="per_min"/>
            <adiabaticHead value="43.13522708373212" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1376765361865325" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10226.125" unit="per_min"/>
            <adiabaticHead value="45.70387995224099" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1474908328417121" unit="m_cube_per_s"/>
          </measurement>
          <measurement>
            <speed value="10805" unit="per_min"/>
            <adiabaticHead value="48.27119029999983" unit="kJ_per_kg"/>
            <volumetricFlowrate value="0.1572999999999993" unit="m_cube_per_s"/>
          </measurement>
        </surgelineMeasurements>
        <characteristicDiagramMeasurements>
          <adiabaticEfficiency value="0.805">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="27.11731693331764" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.1999170861196115" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="29.59425222415977" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2199151588315805" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="32.06306674478081" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2398476667490398" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="34.52444705720519" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2597201529789633" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="36.9790615136017" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2795380136071183" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="39.42756177443493" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.2993065099551883" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="41.8705842330017" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3190307800820762" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="44.30875135576773" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3387158496054024" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="46.74267294701132" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.358366641911879" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8100000000000001">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="25.90677793155012" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3343891167475417" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="28.19075275438971" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.364673889779059" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="30.458678262802" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.3947458540528432" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="32.71219114457632" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4246267115236303" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="34.95283844069665" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4543369754582922" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="37.18208787759301" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4838961074381747" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="39.40133702189578" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5133226387481999" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="41.6119214351115" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5426342785052508" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="43.81512197658386" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5718480104930893" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.8149999999999999">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="23.97273192857296" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.4760333007945044" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="25.98517233651928" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5157257952807245" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="27.97499526193776" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.554972192433089" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="29.94495065043807" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.5938267309761422" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="31.8975552512994" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6323390501719929" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="33.83512757567653" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6705548793206806" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="35.75981714439297" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7085166146308576" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="37.67362917680177" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7462638061720812" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="39.57844561338119" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7838335725152975" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.82">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="21.36831708511362" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6174040759960454" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="23.06427718692367" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.6648979135134168" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="24.73505972043644" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7116866758721703" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="26.38420219166257" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7578694277469444" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="28.01485203923315" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8035343103261913" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="29.62983693318705" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8487605099664978" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="31.231720814941" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8936198275415519" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="32.82284915235382" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9381779457695204" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="34.40538593779291" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.982495465310629" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.7649999999999999">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="18.26186791309906" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.7520406740194827" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="19.63415132800669" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8055492375452742" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="20.98274474712028" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8581340723200652" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="22.3113641181324" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9099400718993759" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="23.62324777484009" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9610935065476524" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="24.92125334240722" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.011705801802763" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="26.20793229360304" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.061876445599398" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="27.48558826930934" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.111695262323048" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="28.75632341060694" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.16124421940722" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.71">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="14.8644140136067" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.8759078660615892" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="15.93232046287505" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9338696041038685" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="16.98047777273439" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9907594369752684" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="18.01225070512434" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.046759990644809" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="19.03053291376626" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.102028321190853" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="20.03784974544394" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.156701494448007" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="21.03643550287122" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.210900779529959" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="22.02829264869924" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.264734862188823" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="23.01523799085006" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.31830235157236" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.655">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="11.36483402253311" unit="kJ_per_kg"/>
              <volumetricFlowrate value="0.9873831597741072" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="12.16001955388578" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.048601120833811" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="12.94023286846357" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.108666434432811" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="13.70819342379745" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.167788460071086" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="14.46622268164719" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.226145917242399" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="15.21633482167517" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.283893869095258" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="15.96030396304071" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.341168897538322" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="16.69971504824885" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.398093020572081" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="17.43600312143611" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.454776716157472" unit="m_cube_per_s"/>
            </measurement>
          </adiabaticEfficiency>
          <adiabaticEfficiency value="0.6">
            <measurement>
              <speed value="6174" unit="per_min"/>
              <adiabaticHead value="7.901548153466043" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.0865" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="6752.875" unit="per_min"/>
              <adiabaticHead value="8.458249660868219" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.150114558486958" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7331.75" unit="per_min"/>
              <adiabaticHead value="9.004601246649781" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.212546426276091" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="7910.625" unit="per_min"/>
              <adiabaticHead value="9.542583492388943" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.274021925410666" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="8489.5" unit="per_min"/>
              <adiabaticHead value="10.07388146379476" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.334733609188416" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9068.375" unit="per_min"/>
              <adiabaticHead value="10.59995381277454" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.394848158489194" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="9647.25" unit="per_min"/>
              <adiabaticHead value="11.12208358872348" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.454512188006347" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10226.125" unit="per_min"/>
              <adiabaticHead value="11.6414164499069" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.513856612680385" unit="m_cube_per_s"/>
            </measurement>
            <measurement>
              <speed value="10805" unit="per_min"/>
              <adiabaticHead value="12.15899" unit="kJ_per_kg"/>
              <volumetricFlowrate value="1.573" unit="m_cube_per_s"/>
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
        <power_fun_coeff_1 value="-171.9322598036645"/>
        <power_fun_coeff_2 value="0.4189881824093836"/>
        <power_fun_coeff_3 value="-1.911261273000259e-05"/>
        <power_fun_coeff_4 value="1.034275700553058"/>
        <power_fun_coeff_5 value="-0.002520465306393195"/>
        <power_fun_coeff_6 value="1.149738329694275e-07"/>
        <power_fun_coeff_7 value="-0.003437589803931522"/>
        <power_fun_coeff_8 value="8.37719172343246e-06"/>
        <power_fun_coeff_9 value="-3.821349333869943e-10"/>
      </gasTurbine>
      <gasTurbine id="drive_6">
        <energy_rate_fun_coeff_1 value="0.01"/>
        <energy_rate_fun_coeff_2 value="0"/>
        <energy_rate_fun_coeff_3 value="0"/>
        <power_fun_coeff_1 value="-383.2543068734815"/>
        <power_fun_coeff_2 value="0.9339668170525938"/>
        <power_fun_coeff_3 value="-4.260393688039167e-05"/>
        <power_fun_coeff_4 value="2.305504605035723"/>
        <power_fun_coeff_5 value="-0.005618370776394535"/>
        <power_fun_coeff_6 value="2.562882423205735e-07"/>
        <power_fun_coeff_7 value="-0.007662733562192398"/>
        <power_fun_coeff_8 value="1.867360326198624e-05"/>
        <power_fun_coeff_9 value="-8.518172168191037e-10"/>
      </gasTurbine>
    </drives>
    <configurations>
      <configuration nrOfSerialStages="1" confId="config_1">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="6380" id="compressor_5"/>
        </stage>
      </configuration>
      <configuration nrOfSerialStages="1" confId="config_2">
        <stage nrOfParallelUnits="1" stageNr="1">
          <compressor nominalSpeed="6380" id="compressor_6"/>
        </stage>
      </configuration>
      <configuration nrOfSerialStages="1" confId="config_3">
        <stage nrOfParallelUnits="2" stageNr="1">
          <compressor nominalSpeed="6380" id="compressor_5"/>
          <compressor nominalSpeed="6380" id="compressor_6"/>
        </stage>
      </configuration>
    </configurations>
  </compressorStation>
</compressorStations>
