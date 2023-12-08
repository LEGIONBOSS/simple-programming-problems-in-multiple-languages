/*
Write a program that asks the user for their name and greets them with their
name.
*/

#include <stdio.h>

int main(int argc, const char *argv[])
{
    char name[255];
    scanf("%s", &name);
    printf("Hello %s!\n", name);
    
    return 0;
}
