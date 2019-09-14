#!/bin/bash

if [ "$1" == "" ]; then
    echo "Path to data file required"
else
    while read LINE; do
        LNE=$LINE
        echo "READ: > $LNE <"
    done < $1
fi

rm $GITHUB_WORKSPACE/data.json