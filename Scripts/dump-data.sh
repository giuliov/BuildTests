while read LINE; do
     echo "READ: $LINE"
done < $GITHUB_WORKSPACE/data.json

rm $GITHUB_WORKSPACE/data.json