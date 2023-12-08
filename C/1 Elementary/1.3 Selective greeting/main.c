/*
Modify the previous program such that only the users Alice and Bob are greeted
with their names.
*/

#include <stdio.h>
#include <string.h>

const char* Alice = "Alice";
const char* Bob = "Bob";

int main(int argc, const char *argv[])
{
    char name[255];
    scanf("%s", &name);
    
    printf("Hello");
    if (strcmp(name, Alice) == 0
        ||
        strcmp(name, Bob) == 0)
    {
        printf(" %s", name);
    }
    printf("!\n");
    
    return 0;
}
