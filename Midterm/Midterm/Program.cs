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
            //  3 types of control structures
            /* Sequential: default mode. Sequential execution of code statements (one line after another) -- like following a recipe
               Selection: used for decisions, branching -- choosing between 2 or more alternative paths. i.e the if, if/else and switch statements
               Repetition: used for looping, i.e. repeating a piece of code multiple times in a row. while, do/while and for loop
            */  

            //infinite loop with boolean keepLooping variable set to true
            int i = 10;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 9) keepLooping = false;
                i++;
                Console.WriteLine(i);
            }

            //while loop to print 2 through 128 in brackets with condition that ends loop after 64 is printed
            int x = 1;
            while (x <= 64)
            {
                if ((x % 2) == 0)
                {
                    Console.WriteLine("[{0}]", x);
                }
                else if ((x % 2) != 0)
                {
                    Console.WriteLine("");
                }
                x *= 2;
            }

            //for loop that prints 49 through 1 separated by a comma
            string a = ",";
            int b;
            for (b = 49; b >= 1; --b)
            {
                Console.Write(b);

                if (b >= 2)
                {
                    Console.Write(a);
                }
            }

            //loop that prints all odd numbers 1 through 21 separated by spaces
            int j = 1;
            while (j <= 21)
            {
                {
                    if ((j % 2) == 0)
                    {
                        Console.Write("  ");
                    }
                    else if ((j % 2) != 0)
                    {
                        Console.Write(i);
                    }
                    i++;
                }
            }

            //what is the output of the following code
            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition
            // the output is *

            //exact code using a while statement
            int n = 8;
            int i = 10; // initialize
            while (i < n)
            {
                Console.Write("*");
                i++;
            }
            //the above code outputs nothing because i isnt greater than n

            //you can combine true/false values by using the Boolean operators.  
            //These take True/false values as operands and computes new true/false values.
            {
                // declare boolean values
                bool icyRain = false;
                bool tornadoWarning = false;

                if ((!icyRain) && (!tornadoWarning))
                {
                    Console.WriteLine("Let's go outside!");
                    Console.ReadLine();
                }
            }



        }
    }
}
