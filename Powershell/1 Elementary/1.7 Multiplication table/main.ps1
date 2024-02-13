<#
Write a program that prints a multiplication table for numbers up to 12.
#>

# Header
Write-Host "x" -NoNewline
for ($i = 1; $i -le 12; $i++)
{
    Write-Host "`t$i" -NoNewline
}
Write-Host

# Table
for ($i = 1; $i -le 12; $i++) # rows (base number)
{
    Write-Host "$i" -NoNewline
    for ($j = 1; $j -le 12; $j++) # columns (result)
    {
        $m = $i * $j
        Write-Host "`t$m" -NoNewline
    }
    Write-Host
}
