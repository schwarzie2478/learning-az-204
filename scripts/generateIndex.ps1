pushd $PSScriptRoot\..

$list = gci '*.md' -Recurse | ?{ $_.Name -ne "ReadMe.md"}
$path = $list | Resolve-Path -Relative 
# join list and path together
$index = $list | % { "[{0}]({1})" -f $_.Name, $path[$list.IndexOf($_)] } | Out-String
# write to ReadMe.md
$index | set-content index.md -force



popd

