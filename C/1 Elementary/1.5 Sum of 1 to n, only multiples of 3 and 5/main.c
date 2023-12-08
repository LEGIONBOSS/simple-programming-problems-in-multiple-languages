/*
Modify the previous program such that only multiples of three or five are
considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17
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
        if (i % 3 == 0
            ||
            i % 5 == 0)
        {
            sum += i;
        }
    }
    printf("sum = %i\n", sum);
    
    return 0;
}
