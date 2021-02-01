#!/bin/bash 

# Check if we use windows. This should get both MinGW (uname MINGW32_NT-6.1)
# and Cygwin (uname CYGWIN_NT-6.1)
WINDOWS=$(uname -s | grep "_NT")
if [ $WINDOWS ]
then
	./marbleblast.exe -compileall
else
	./Contents/MacOS/MBExtender -compileall
fi

cat ./console.log | grep ' - Syntax error.'
