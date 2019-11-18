using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 Basic elements of the counter-controlled repetition:
              A control variable (or loop counter)
              The control variable’s initial value
              The control variable’s increment that’s applied during each iteration of the loop
              The loop-continuation condition that determines if looping should continue
            */

            /* Compare and contrast While and for repetition statements   
              The while and for repetition statements repeatedly execute statement(s) as long as a loop-continuation condition remains true. 
              Both statements execute their bodies zero or more times. 
              The for repetition statement specifies the counter-controlled-repetition details in its header,
              whereas the control variable in a while statement normally is initialized before the loop and incremented in the loop's body. 
              In most cases, for statements are used for counter-controlled repetition, and while
              statements are used for sentinel-controlled repetition. However, while and for can each be used for either repetition type.
            */

           //when to use a do-while statement than a while statement.  
           /* A while statement executes statement repeatedly until expression evaluates to zero. A do-while loop executes one or more times, depending on the value of the termination expression.
             The difference between do-while and while is that the while loop tests the loop condition at the top of the loop while the do-while evaluates its expression at the bottom of the loop.
             Therefore, the statements within the do block are always guaranteed to execute at least once.

             If you want some statement or set of statements to execute at least once, then repeat
             based on a condition, a do…while is more appropriate than a while. 

             For example if a program needs to obtain a positive integer value from the user for the program to continue. 
             A do…while’s body could contain the statements required to obtain the user input, and the loop-continuation
             condition could determine whether the value entered is less than 0. Then the loop would repeat and prompt the user for input until the user entered a value greater than or equal to zero. 
             Once this criteria is met the loopcontinuation condition would become false, and the loop would terminate, allowing the program to continue past the loop. 

             */

            //loop that goes from 1-100 using a variable named j as the counter
            for (int j = 1; j < 101; j++)
            {
                Console.WriteLine(j);
                {
                    if ((j % 2) == 0)
                    { Console.WriteLine("Even Number"); }
                    else if ((j % 2) != 0)
                    {
                        Console.WriteLine("Odd Number");
                        Console.ReadLine();
                    }
                }
            }

            //if else-if else statement to output statement based on inputed temperature
            Console.Write("Please enter a temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 10) 
            {Console.WriteLine("Polar Bear"); }
            else if (temp < 20) 
            { Console.WriteLine("Penguin"); }
            else if (temp < 40) 
            { Console.WriteLine("Moose"); }
            else if (temp < 50) 
            { Console.WriteLine("Reindeer"); }
            else if (temp < 60) 
            { Console.WriteLine("Deer"); }
            else if (temp < 70) 
            { Console.WriteLine("Turtle"); }
            else if (temp < 80) 
            { Console.WriteLine("Lion"); }
            else if (temp < 90) 
            { Console.WriteLine("Fish"); }
            else 
            { Console.WriteLine("Bug"); }
            Console.ReadLine();

            //Code to loop and output 10-20
            //initial code didnt include the increment operator
            int i = 9;
            while (i < 20)
            {
                i++;
                Console.WriteLine(i);
                Console.ReadLine();
            }

            //Code to output every number from 0-100 separated by a line with asterisks on it
            //initial code missing curly bracket
            for (int x = 0; x < 101; x++)
            {
                Console.WriteLine(x);
                Console.WriteLine("********");
                Console.ReadLine();
            }
        }
    }
}

