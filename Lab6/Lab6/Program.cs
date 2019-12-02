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
            //Question 2
            /*A one-dimensional array p contains four elements.
             The array access expressions to access each of the elements in p are P[0], p[1], p[2] and p[3].*/

            //Question 3 Create a 12-element array called months
            {
                string[] months =
                   {
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July",
                    "August",
                    "September",
                    "October",
                    "November",
                    "December"
                    };

                for (int i = 0; i < months.Length; i++)
                {
                    Console.WriteLine(i + " " + months[i]);
                }
            }

            //Question 4: Create a 4-element array to store the names of 4 seasons
            {
                string[] seasons;
                seasons = new string[4] { "Winter", "Spring", "Summer","Fall" };
                foreach (string s in seasons)
                {
                    Console.WriteLine(s);
                }
            }

            //Question 5: Create an array of integers with 1000 elements
            {
                int[] randomNumber = new int[1000];
                Random random = new Random();
                for (int i = 0; i < randomNumber.Length; i++)
                {
                    randomNumber[i] = random.Next(0, 1000);
                }
                foreach (int i in randomNumber)
                {
                    Console.WriteLine(i.ToString());
                }
            }

            //Question 6
            {
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                int i = 0;
                while (i < names.Length)
                {
                    Console.WriteLine(names[i]);
                    i++;
                }
            }

            //Question 7
            {
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                int i = 0;
                while (i < names.Length)
                {
                    Console.WriteLine("{0,2}. {1}", i, names[i]);
                    i++;
                }
            }

            //Question 8
            {
                string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                int i = 0;
                foreach (string name in names)
                {
                    Console.WriteLine("{0,2}. {1}", i, names[i]);
                    i++;
                    Console.ReadLine();
                }
            }
        }
    }
}