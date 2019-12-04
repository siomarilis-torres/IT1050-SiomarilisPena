using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

2.	Fill in the blanks in the following statement:
A one-dimensional array p contains four elements.The array access expressions to access each of the elements in p are __p[0] _, _p[1] _, __p[2] __ and __p[3]____.

3.	Create a 12-element array called months.  Set each element to the name of each month.
For example months[0] = “January”.  Use a for loop to display the number and name of each month.

    static void Main(string[] args)
{
    int[] array = new int[12];
    month[0] = "january";
    month[1] = "february";
    month[2] = "march";
    month[3] = "april";
    month[4] = "may";
    month[5] = "june";
    month[6] = "july";
    month[7] = "august";
    month[8] = "september";
    month[9] = "october";
    month[10] = "november";
    month[11] = "december";
    {
        for int counter = 0; counter < array.Length; ++counter):
        Console.WriteLine(" {0}{1,15}", counter, string[month]);
    }

    4.Create a 4 - element array to store the names of 4 seasons.Use a foreach loop to display the name of each season.

      {
        class Program
{
    string void Main(string[] args)
    {
        string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
        Console.WriteLine("The Four Seasons");
        foreach (string season in seasons)
        {
            Console.WriteLine(season);

            5.Create an array of integers with 1000 elements.Fill the array with random numbers.  Use a foreach loop to print all integers in the array.
        Random random = new Random();
            int randomNumber
            randomNumber = random.Next(0, 100);  // place this line in the loop

            {
                class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[1000];
            {
                Random randomNumbers = new Random(1000);
                int randomNumber = randomNumber.Next();
                {
                    foreach (randomNumber in randomNumber.Next(0, 100)) ;  // place this line in the loop
                    Console.WriteLine("{0}");
                }
            }
        }

        6.	Paste the following code into the main() method.Modify the code; so that it works(You’ll have to make 2 small modifications).  It should output the value of each string in the array called names.


string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

        int i = 0;
while (i<names.Length)
{
    Console.WriteLine(names[0]);
}
    {
        class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            {
                while (i < names.Length)
                    Console.WriteLine(string[names]);
            }
        }
    }



  7.	Modify the code from problem 5, so that it outputs a number and then a person’s name using the following output statement.

Console.WriteLine("{0,2}. {1}", i, names[i]);

            
            class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
        int i = 0;
        {
            for (int i = 0; i < names.Length; ++i) ;

            Console.WriteLine("{0,2}. {1}", i, names[i]);
        }
    }
}



8.	Modify the code from problem 6, so that it uses a foreach loop as opposed to a while loop.The output should appear exactly the same as it did after step 2.


class Program
{
    static void Main(string[] args)
    {

        string[] names = new string[5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
        int i = 0;
        {
            foreach (string name in names)
                Console.WriteLine("{0,2}.{1}", i, names[i]);
        }
    }
}
