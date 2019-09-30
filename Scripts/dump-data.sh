#!/bin/bash

if [ "$1" == "" ]; then
    echo "Path to data file required"
else
    export FNAME=$1
    
    F1=$(jq -r '.field1?' $FNAME)
    F2=$(jq -r '.field2?' $FNAME)
    F3=$(jq -r '.field3?' $FNAME)
    
    echo "Found $F1,$F2,$F3."

    rm $FNAME
fi
