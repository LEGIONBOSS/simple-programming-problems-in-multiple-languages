<#
Modify the previous program such that only the users Alice and Bob are greeted
with their names.
#>

$name = Read-Host -Prompt "What is your name?"

Write-Host "Hello" -NoNewline
if ($name -eq "Alice" -or $name -eq "Bob")
{
    Write-Host " $name" -NoNewline
}
Write-Host "!"
