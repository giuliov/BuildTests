#!/bin/bash

if [ "$1" == "" ]; then
    echo "Path to data file required"
else
    jq -r '.' $1
fi

rm $1