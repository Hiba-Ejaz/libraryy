using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class TextBook : Book, IBorrowable,IPrintable
    {

        public TextBook(int isbn, string title, string author, DateOnly pubDate, bool canBorrow, bool canPrint)
            : base(isbn, title, author, pubDate, canBorrow, canPrint)
        {
        }
        public void BorrowBook(Book book)
        {
            Console.WriteLine("inside TextBook BorrowBook");
        }

        public void PrintPages(int startPage,int endPage)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}