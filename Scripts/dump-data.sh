cp $GITHUB_WORKSPACE/data.json $GITHUB_WORKSPACE/data-2.json

while read LINE; do
    LNE=$LINE
    echo "READ: > $LNE <"
done <  $GITHUB_WORKSPACE/data-2.json

rm $GITHUB_WORKSPACE/data.json
rm $GITHUB_WORKSPACE/data-2.json