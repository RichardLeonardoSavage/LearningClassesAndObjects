using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {


            //this creates a new instance of the class - this is called an object and can now be used similar to a variable
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings ";
            book2.author = "J.R.R. Tolkien ";
            book2.pages = 650;

            Console.WriteLine(book2.title);

            Console.ReadLine();

        }
    }
}