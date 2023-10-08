@echo off
setlocal enabledelayedexpansion

REM Read the paths from path.txt
for /f "delims=" %%a in (path.txt) do (
    REM Change the current directory to the repository path
    cd %%a

    REM Run the commands in a.bat
    call a.bat %1
)
pause

endlocal
