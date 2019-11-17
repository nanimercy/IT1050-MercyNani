﻿using System;
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
            //Basic elements of the counter-controlled repetition:
            //a control variable (or loop counter),
            //the control variable’s initial value,
            //the control variable’s increment that’s applied during each iteration of the loop,
            //the loop-continuation condition that determines if looping should continue.

            //while and for repetition statements
            /*      
             *The while and for repetition statements repeatedly execute a statement or set of
              statements as long as a loop-continuation condition remains true. Both statements
              execute their bodies zero or more times. The for repetition statement specifies the
              counter-controlled-repetition details in its header, whereas the control variable in a
              while statement normally is initialized before the loop and incremented in the loop's
              body. Typically, for statements are used for counter-controlled repetition, and while
              statements are used for sentinel-controlled repetition. However, while and for can
              each be used for either repetition type.
             */

            //when to use a do-while statement than a while statement.  
            /*
             If you want some statement or set of statements to execute at least once, then repeat
             based on a condition, a do…while is more appropriate than a while (or a for). A
             do…while statement tests the loop-continuation condition after executing the loop’s
             body; therefore, the body always executes at least once. A while tests the loop-continuation condition before executing the loop’s body, so the program would need to
             include the statement(s) required to execute at least once both before the loop and in
             the body of the loop. Using a do…while avoids this duplication of code. Suppose a
             program needs to obtain an integer value from the user, and the integer value entered
             must be positive for the program to continue. In this case, a do…while’s body could
             contain the statements required to obtain the user input, and the loop-continuation
             condition could determine whether the value entered is less than 0. If so, the loop
             would repeat and prompt the user for input again. This would continue until the user
             entered a value greater than or equal to zero. Once this criterion was met, the loopcontinuation condition would become false, and the loop would terminate, allowing
             the program to continue past the loop. This process is often called validating input.
             */

             //loop that goes from 1-100
            for (int j = 1; j < 101; j++)
            {
                Console.WriteLine(j);
                {
                    if ((j % 2) == 0)
                    { Console.WriteLine("Its Even"); }
                    else if ((j % 2) != 0)
                    {
                        Console.WriteLine("Its Odd");
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
            int i = 9;
            while (i < 20)
            {
                i++;
                Console.WriteLine(i);
                Console.ReadLine();
            }

            //Code to output every number from 0-100 separated by a line with asterisks on it
            for (int x = 0; x < 101; x++)
            {
                Console.WriteLine(x);
                Console.WriteLine("********");
                Console.ReadLine();
            }
        }
    }
}

