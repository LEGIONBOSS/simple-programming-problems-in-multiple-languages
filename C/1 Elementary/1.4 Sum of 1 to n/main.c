/*
Write a program that asks the user for a number n and prints the sum of the
numbers 1 to n
*/

#include <stdio.h>

int main(int argc, const char *argv[])
{
    int n = 0;
    printf("n = ");
    scanf("%i", &n);

    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    printf("sum = %i\n", sum);
    
    return 0;
}
