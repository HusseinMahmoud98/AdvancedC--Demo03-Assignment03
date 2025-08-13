using System.Runtime.Intrinsics.X86;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            books.Add(new Book("1234", "Dot Net", new string[] { "Hussein", "Mahmoud" }, DateTime.Now, 100));
            books.Add(new Book("5678", "NodeJs", new string[] { "Ahmed", "Tarek" }, DateTime.Now, 120));
            books.Add(new Book("911", "PHP", new string[] { "Yara", "Sameh" }, DateTime.Now, 50));

            //a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            fptr_BookFunctions fptr_GetPrice = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, fptr_GetPrice);
            Console.WriteLine();

           // b) Use the Proper build in delegate.
           Func<Book, string> func_GetTitle = BookFunctions.GetTitle;
           LibraryEngine.ProcessBooksFunc(books, func_GetTitle);
            Console.WriteLine();

            //c) Anonymous Method (GetISBN).
            Func<Book, string> func_GetISBN = delegate (Book book) { return book.ISBN; };
            LibraryEngine.ProcessBooksFunc(books, func_GetISBN);
            Console.WriteLine();

            //d) Lambda Expression (GetPublicationDate).
            LibraryEngine.ProcessBooksFunc(books, book => book.PublicationDate.ToString());


        }
    }
}
