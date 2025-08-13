using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public delegate string fptr_BookFunctions(Book B);
    internal class LibraryEngine
    {
       public static void ProcessBooks(List<Book> bList, fptr_BookFunctions fPtr)
       {
          foreach (Book B in bList)
          {
              Console.WriteLine(fPtr(B));
          }
       }

        public static void ProcessBooksFunc(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

    }
}
