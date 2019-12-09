using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        //created an object mybook to access Book class method and properties
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "On Earth We're Briefly Gorgeous";
            myBook.Author = "Ocean Vuong";
            myBook.Year = 2019;
            myBook.Display();
        }
    }

    // Access specifier & properties
   public class Book
   { 
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

      //Method
      public void Display()
        {

            Console.WriteLine("Title: {0}\nAuthor: {1}\nYear: {2}",
                Title, Author, Year);
            Console.ReadLine();
        }
   }




}
    
