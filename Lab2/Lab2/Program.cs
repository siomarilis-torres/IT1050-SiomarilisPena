using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second interger: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            //multiplcation  multiplication - 7 * 15;
            int product = integer1 * integer2;
            Console.WriteLine("Product is {0}", product); // display product
            
            Console.WriteLine("{0}\t{1}", "Hello World!", "Siomarilis Pena");

            /*
            a.  program executes at the end of main

            b. an integer is a number without a decimal, whereas a double/floating-point variable is a number that has a decimal place

            c. Console.WriteLine( "Welcome to the Grade Book!" );

            d. To read the value of an instance variable, we create a method called get accessor. To assign a value ton instance variable, we use a method called a set accessor.

            e. An object is an instance of a class and aclass is used to house a method. One can create many instances of a class, however each must have a different object
            */
        }
    }
}
    
    