$IndexReference = "[Back to Index](Index.md)"
$list = gci *.md -Recurse
$list | %{ 
    $last_line = get-content -Tail 1 $_
    if( $last_line -ne $IndexReference)
    {
        add-content $_ "`n$IndexReference"
    }
}   


