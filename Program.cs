using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();

            //1 
            //Console.WriteLine(myBook.password);
            // compilation error.
            // why ? because password is private and cannot be accessed outside the class.

        }
    }
}