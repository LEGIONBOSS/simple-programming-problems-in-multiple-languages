<#
Write a program that asks the user for a number n and prints the sum of the
numbers 1 to n.
#>

[int]$n = Read-Host -Prompt "n"
$sum = 0
for ($i = 1; $i -le $n; $i++)
{
    $sum += $i
}
Write-Host "sum: $sum"
