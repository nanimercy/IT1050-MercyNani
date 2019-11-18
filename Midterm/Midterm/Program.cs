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
            int a = 10;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (a <= 9) keepLooping = false;
                a++;
                Console.WriteLine(a);
            }
            


            //while loop to print 2 through 128 in brackets with condition that ends loop after 64 is printed
            int x = 2;
            while (x < 128)
            {
                Console.WriteLine("{" + x + "}");
                x = x + x;
            }
        

            //for loop that prints 49 through 1 separated by a comma
            
                for (int p = 49; p > 0; p--)
                {
                    Console.Write(p);

                    if (p != 1)
                    {
                        Console.Write(",");
                    }
                }
            


            //loop that prints all odd numbers 1 through 21 separated by spaces

            int j = 1;
            while (j <= 21)
            {
                if ((j % 2) == 0)
                {
                    Console.Write("  ");
                }
                else if ((j % 2) != 0)
                {
                    Console.Write(j);
                }
                j++;
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
            {
                int y = 8;
                int z = 10; // initialize
                while (y < z)
                {
                    Console.Write("*");
                    y++;
                }
            }
            //the above code outputs nothing because y isnt greater than z
 
            //We can combine mutiple boolean values by using the boolean operators AND and OR (and NOT).
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
