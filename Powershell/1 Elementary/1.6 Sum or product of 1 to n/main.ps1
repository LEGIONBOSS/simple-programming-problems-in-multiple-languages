<#
Write a program that asks the user for a number n and gives them the possibility
to choose between computing the sum and computing the product of 1,...,n.
#>

[int]$n = Read-Host -Prompt "n"
$method = Read-Host -Prompt "[S]um or [P]roduct"

if ($method -ieq "S")
{
    $res = 0
    for ($i = 1; $i -le $n; $i++)
    {
        $res += $i
    }
    Write-Host "Sum: $res"
}
else
{
    $res = 1
    for ($i = 1; $i -le $n; $i++)
    {
        $res *= $i
    }
    Write-Host "Product: $res"
}
