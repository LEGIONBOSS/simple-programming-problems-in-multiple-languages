/*
Write a program that asks the user for a number n and gives them the possibility
to choose between computing the sum and computing the product of 1,...,n.
*/

#include <stdio.h>

int main(int argc, const char *argv[])
{
    printf("n = ");
    int n = 0;
    scanf("%i", &n);

    printf("sum (s) or product (p): ");
    char c;
    scanf("%c", &c);

    int res = 1;
    for (int i = 2; i <= n; i++)
    {
        if (c == 's') // sum
        {
            res += i;
        }
        else // product
        {
            res *= i;
        }
    }

    printf("res = %i\n", res);
    
    return 0;
}
