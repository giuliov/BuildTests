param(
    [string] $datafile
)
$x = Get-Content $datafile | ConvertFrom-Json

$x
$x | Get-Member -MemberType NoteProperty
$x | Get-Member -MemberType NoteProperty | foreach { $x."$($_.Name)" }
