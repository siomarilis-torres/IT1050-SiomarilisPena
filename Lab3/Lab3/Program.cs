using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
The if single-selection statement is similar to the while repetition statement in a way that they both perform an action based 
on whether a condition is true or false. The difference is if the condition is true the if single-selection statement will perform 
the action once while the while repetition statement will repeat the action until it becomes false.

    if (speed > speedlimit)
{
  Console.Writeline("Slow down");
}
 else
{
  Console.Writeline("Speed is acceptable");

}
    /**
 * C program to convert temperature from degree fahrenheit to celsius
 */

#include <stdio.h>

int main()
{
    float celsius, fahrenheit;

    /* Input temperature in fahrenheit */
    printf("Enter temperature in Fahrenheit: ");
    scanf("%f", &fahrenheit);

    /* Fahrenheit to celsius conversion formula */
    celsius = (fahrenheit - 32) * 5 / 9;

    /* Print the value of celsius */
    printf("%.2f Fahrenheit = %.2f Celsius", fahrenheit, celsius);

    return 0;
}
#include <stdio.h>
int main()
{
    int count = 1;
    while (count >= 1)
    {
        printf("%d ", count);
        count++;
    }
    return 0;

# include <stdio.h>
    int main()
    {
        int count = 5;
        while (count <= 60)
        {
            printf("%d ", count);
            count--;
        }
        return 0;

# include <stdio.h>
        int main()
        {
            int count = 2;
            while (count >= 10)
            {
                printf("%d ", count);
                count++;
            }
            return 0;