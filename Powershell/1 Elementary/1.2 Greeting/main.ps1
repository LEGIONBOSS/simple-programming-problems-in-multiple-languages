<#
Write a program that asks the user for their name and greets them with their
name.
#>

$name = Read-Host -Prompt "What is your name?"
Write-Host "Hello $name!"
