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
            int number1;
            int number2;
            int multiply;

            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            multiply = number1 * number2;

            Console.WriteLine("Multiplication is {0}", multiply);
            Console.ReadLine();

            Console.WriteLine("{0}\n{1}", "HelloWorld!", "From Mercy Nani");
            Console.ReadLine();

            Console.WriteLine("HelloWorld!   From Mercy Nani");
            Console.ReadLine();

        }
    }
}
