namespace Assignment
{
    
    public enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    public class Book
    {
        //1
        private string password = "secret";

        //2 
        internal int copiesInStock = 5; 
    }
}