set WORKSPACE=..

set GEN_CLIENT=%WORKSPACE%\LubanConfigProject\Luban.ClientServer\Luban.ClientServer.exe
set CONF_ROOT=%WORKSPACE%\LubanConfigProject\Config

%GEN_CLIENT% -j cfg --^
 -d %CONF_ROOT%\Defines\__root__.xml ^
 --input_data_dir %CONF_ROOT%\Datas ^
 --output_code_dir %WORKSPACE%\LocalPackages\com.focuscreativegames.luban\Gen ^
 --output_data_dir %WORKSPACE%\Assets\Res\Configs\bytes ^
 --gen_types code_cs_unity_bin,data_bin ^
 -s all 

pause