using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

2.	Identify and briefly describe 3 types of control structures that we can use to order the statements in our programs?  

    if statements:used to evaluate a boolean expression
    loops:used for interative purposes
    switch statement: can replace if statements


3.	Create an infinite while loop.Use a Boolean variable called keepLooping that set to true in the loop’s termination condition.Hint: Use CTRL+C or Debug -> Terminate All to end the program.

    int i = 12;
    Boolean keepLooping = true;
    while (keepLooping)
    {
        if  ( i<= 11
             keepLooping = false;
       i++
       Console.WriteLine(i);
    }
}




4.	Write a while loop to prints 2 through 128 in brackets, each on a new line.You should initialize your loop control variable to 2.  Output the value of the loop control variable each time through the loop.Use a condition that ends the loop after 64 is printed.


[2]
[4]
[8]
[16]
[32]
[64]
[128]

        class Program
{
    static void Main(string{ } args)
        {           
            int loop = 2;

            while (loop < 128)

            {   
                Console.WriteLine("[" + loop + "]")

                loop = loop + loop;

               }
        }
}


5.	Write a for loop that prints 49 through 1 separated by a comma.Note, you will need to use a condition inside of the loops so it does not print the comma the last time through (no newlines).

49, 48, 47, …, 3, 2, 1

                   string j = ","
                   int i;
                   for (i = 49; i >= 1; --1
                   {
                        Console.Write (i);
                        if  (i>=2)
                        {
                        Console.Write (j);
                     }
                }

6.	Write a while loop that prints all odd numbers 1 through 21 separated by spaces (no newlines).

1 3 5 7 9 11 13 15 17 19 21

                    int i = 1;
                    while  (i <=21
                    {
                        {
                            if  ((i % 2) ==0)
                            {
                                Console.Write(" ");
                            }
                            else if  ((i % 2) !=0)
                            {
                                Console.Write(i);
                            }
                            i++;
                        }
                    }
                    

7.	What is the output for the following code?
int n = 8;
int i = 10; // initialize
do {
   Console.Write("*");
   i++; // update!
} while (i<n); // test condition

What would the output be with the exact same code but using a while statement as opposed to a do-while?


    int n = 8;
    int n = 10;
    while  (i < n)
    {
        Console.Write("*");
            i++
       }



8.	Explain how do we combine multiple Boolean values? Write an if statement that outputs “Let’s go outside!” when both Boolean values are false.
boolean icyRain;
boolean tornadoWarning;

    Boolean values are combined using integers

    class Program
    {
    static void Main(string[] args)
    {
        bool icyrain = false, tornadowarning = false;
        if icyrain == false && tornadowarning == false)
        {
            Console.WriteLine("Lets go outside");
        }
    }
        



9.	Extra Credit: Use nested loops to print the following to the console:

        123454321
         1234321
          12321
           121
            1

    class program
    {
    static void Main(string[] args)
    {
        int numberoflayer = 5, Space, Number;
        Console.WriteLine("Print pyramid");
        for (int i = 1; i <= numberoflayer; i++)
        {
            for (Space = 1; Space <= (numberoflayer - i); Space++)
                Console.Write("");
            for (Number = 1; Number <= i; Number++)
                Console.Write(Number);
            for (Number = (i - 1); Number >= 1; Number--)
                Console.Write(Number);
                Console.WriteLine();
        }
    }
     
