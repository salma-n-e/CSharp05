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


            //2 
            Console.WriteLine(myBook.copiesInStock);
            // 5 
            // why ? because copiesInStock is internal and can be accessed within the same assembly.

        }
    }
}