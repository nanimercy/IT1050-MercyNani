using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //if single-selection statement vs the while repetition statement
            /* The if single-selection statement and the while repetition statement both perform
             * an action (or set of actions) based on whether a condition is true or false. However,
             * if the condition is true, the if single-selection statement performs the action(s) once, 
             * whereas the while repetition statement repeatedly performs the action(s) until the 
             * condition becomes false. */

            int speedlimit;
            int speed;
            speedlimit = 35;
            speed = 42;
            if
                (speed > speedlimit)
            {
                Console.Write("SLOW DOWN!");
                Console.ReadLine();
            }

            // ifelse statement for isTrue variable
            int isTrue;
            isTrue = 20;
            if
            (isTrue >= 20)
                Console.WriteLine("It is True");
            else
            {
                Console.WriteLine("It is False");
                Console.ReadLine();
            }
            if (isTrue <= 19)
            {
                Console.WriteLine("It is True");
            }
            else
            {
                Console.WriteLine("It is False");
                Console.ReadLine();
            }


            //program that converts Fahrenheit to Celsius
                Console.WriteLine("Enter temperature in Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;
                Console.WriteLine("Temperature in Celsius is: " + celsius);
                Console.ReadLine();

            if (fahrenheit < 40)
                Console.WriteLine("It is Cold!");
            if (fahrenheit <= 90)
                Console.WriteLine("It is Cool!");
            else
                Console.WriteLine("It is Hot!");
                Console.ReadLine();


            //while loop that outputs values 1 to 10. Increment by 1
            int x = 1;
            while (x < 11)
            {
                Console.WriteLine(x);
                Console.ReadLine();
                x++;
                
            }

            //while loop that outputs values 60 to 20. Decrement by 5
            int a = 60;
            while (a >= 20)
            {
                Console.WriteLine(a);
                Console.ReadLine();
                a = a - 5;
            }

            //while loop that outputs values 10 to 20. Increment by 2
            {
                int j = 10;
                while (j <= 20)
                {
                    Console.WriteLine(j);
                    Console.ReadLine();
                    j = j + 2;
                }

            }
        }
    }

}






