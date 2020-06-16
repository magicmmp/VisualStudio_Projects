#!/bin/sh

git add *
date_time=$(date)
git commit -m "auto git push hhh VisualStudio_Projects: ${date_time}"
#git commit -m "自己写的串口上位机V1，在文件夹SerialPort_Test: ${date_time}"
git push origin master