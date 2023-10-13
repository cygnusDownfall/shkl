@echo off
setlocal enabledelayedexpansion


for /f "delims=" %%a in (path.txt) do (
    cd %%a

    call a.bat %1
)
pause

endlocal
