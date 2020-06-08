#!/bin/sh

git add *
date_time=$(date)
git commit -m "auto git push VisualStudio_Projects: ${date_time}"
git push origin master