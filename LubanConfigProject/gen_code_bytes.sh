
#!/bin/zsh
WORKSPACE=..

GEN_CLIENT=${WORKSPACE}/LubanConfigProject/Luban.ClientServer/Luban.ClientServer.dll
CONF_ROOT=${WORKSPACE}/LubanConfigProject/Config


dotnet ${GEN_CLIENT} -h ${LUBAN_SERVER_IP} -j cfg --\
 -d ${CONF_ROOT}/Defines/__root__.xml \
 --input_data_dir ${CONF_ROOT}/Datas \
 --output_code_dir ${WORKSPACE}/LocalPackages/com.focuscreativegames.luban/Gen \
 --output_data_dir ${WORKSPACE}/Assets/Res/Configs/bytes \
 --gen_types code_cs_unity_bin,data_bin \
 -s all 
