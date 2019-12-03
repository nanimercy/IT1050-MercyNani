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
            //  Question 2: 3 types of control structures
            /* Sequential: default mode. Sequential execution of code statements (one line after another) -- like following a recipe
               Selection: used for decisions, branching -- choosing between 2 or more alternative paths. i.e the if, if/else and switch statements
               Repetition: used for looping -- repeating a piece of code multiple times in a row. i.e while, do/while and for loop
            */

            //Question 3:infinite loop with boolean keepLooping variable set to true
            /* uncomment to run keeplooping code
            int a = 9;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (a <= 8) keepLooping = false;
                a++;
                Console.WriteLine(a);
            } */


            //Question 4: while loop to print 2 through 128 in brackets with condition that ends loop after 64 is printed
            {
                int i = 2;
                while (i < 128)
                {
                    Console.WriteLine("{" + i + "}");
                    i = i + i;
                }
                Console.WriteLine("\n");
            }

            //Question 5: for loop that prints 49 through 1 separated by a comma
            {
                for (int p = 49; p > 0; p--)
                {
                    Console.Write(p);
                    if (p != 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine("\n");
            }

            //Question 6: loop that prints all odd numbers 1 through 21 separated by spaces
            {
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
                Console.WriteLine("\n");
            }

            //Question 7: what is the output of the following code
            {
                int n = 8;
                int i = 10; // initialize
                do
                {
                    Console.Write("*");
                    i++; // update!
                } while (i < n); // test condition
                                 /* the result of the output is "*" because this is a do while loop and it will execute the build of the loop 
                                    at least once before testing the condition relating to the while statement */
            }
            //exact code using a while statement 
            {
                int n = 8;
                int i = 10; // initialize
                while (i < n)
                {
                    Console.Write("*");
                    i++;
                }
                /*The above code outputs nothing because the while loop will test the condition before executing the build and since
                   "i" isnt less than "n" the app outputs nothing */
                Console.WriteLine("\n");
            }

            //Question 8
            //We can combine mutiple boolean values by using the boolean operators AND and OR (and NOT).
            {
                bool icyRain = false;
                bool tornadoWarning = false;

                if (icyRain == false && tornadoWarning == false)
                {
                    Console.WriteLine("Let's go outside!");
                }
                Console.WriteLine("\n");
            }

            //Nested loop
            {
                int q = 6; // Total Number of Lines...
                           // Print simple pyramid..
                for (int s = (q - 1); s >= 1; s--)
                {
                    // Loop For Space
                    for (int t = 1; t <= (q - s); t++)
                        Console.Write(" ");
                    //increase the number value
                    for (int Number = 1; Number <= s; Number++)
                        Console.Write(Number);
                    //decrease the number value
                    for (int Number = (s - 1); Number >= 1; Number--)
                        Console.Write(Number);
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
