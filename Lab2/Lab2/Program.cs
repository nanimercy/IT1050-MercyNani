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

            /* (a)If the program contains no errors the Console application executes when you press the start button on the Visual studio window or Ctrl + F5 
             *    
             * (b)Integer variables are whole numbers that can have both zero, positive and negative values but no decimal values. For example, 0, -5, 10
             *   Double/floating-point variabales can hold real numbers (numbers that can have a fractional part). Floats are used when more precision is needed.
             *   
             * (c)The GetName Method retrieves the name of the constant in the specified enumeration that has the specified value.
             * 
             * (d)To read the value of an instance variable, we create method called a get accessor. To assign a value ton instance variable, we use a method called a set accessor.
             * 
             * (e)A class is the building block of C#; it holds its own data members and functions.It is like a blueprint that specifies what the type can do.
             *    An object is basically a block of memory that has been allocated and configured according to the blueprint.
             *    The class is a technique used to bind data and its associated functions together, in contrast, Object is the created instance of a class.
             *   
             *   We can create multiple instance of a class. Each class you create becomes a new type you can use to create objects.
             *   If you define a class called Person, Person is the name of the type. If you declare and initialize a variable p of type Person, p is said to be an object or instance of Person.
             *   Multiple instances of the same Person type can be created, and each instance can have different values in its properties and fields.
             */

        }
    }
}
