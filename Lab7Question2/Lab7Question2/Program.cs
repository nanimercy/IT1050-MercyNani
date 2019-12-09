using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookTest myBook = new BookTest();
            Console.WriteLine(myBook.Title);
            Console.WriteLine(myBook.Author);
            Console.WriteLine(myBook.Year);
            Console.ReadLine();
        }
    }
    public class BookTest
    {
            public string Title, Author, Year;
            //Constructor
            public BookTest()
            {
                Title = "On Earth We're Briefly Gorgeous";
                Author = "Ocean Vuong";
                Year = "2019";
            }
    }


    
}
