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

            //3 
            myBook.Title = "CSharp 05";
            Console.WriteLine(myBook.Title);


            //4 
            myBook.BookGenre = Genre.Science;
            Console.WriteLine(myBook.BookGenre);

            //5
            Console.WriteLine((int)Genre.Fiction);    
            Console.WriteLine((int)Genre.NonFiction); 
            Console.WriteLine((int)Genre.Science);

            //6
            int genreNumber = 1;
            Genre convertedGenre = (Genre)genreNumber;
            Console.WriteLine(convertedGenre); // NonFiction
        }
    }
}