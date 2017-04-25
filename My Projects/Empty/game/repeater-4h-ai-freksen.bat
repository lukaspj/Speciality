@echo off
:loop
start Game.exe -commandLine -aiClient 5542 -ai2 FreksenThink -speed 1000
timeout /t 14400 >null
taskkill /f /im Game.exe >nul
goto loop