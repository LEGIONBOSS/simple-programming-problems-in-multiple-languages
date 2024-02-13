<#
Modify the previous program such that only multiples of three or five are
considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17.
#>

[int]$n = Read-Host -Prompt "n"
$sum = 0
for ($i = 3; $i -le $n; $i++)
{
    if ($i % 3 -eq 0 -or $i % 5 -eq 0)
    {
        $sum += $i
    }
}
Write-Host "sum: $sum"
