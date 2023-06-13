using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class Comic:Book,IBorrowable
    {

    public Comic(int isbn, string title, string author, DateOnly pubDate, bool canBorrow, bool CanPrint, string artist)
        : base(isbn, title, author, pubDate, canBorrow, CanPrint)
    {
        Artist = artist;
    }        private string Artist{get; set;}

        public void BorrowBook()
        {
            throw new NotImplementedException();
        }

        public void ReturnBook()
        {
            throw new NotImplementedException();
        }
        public override void PrintInfo(Book book)
        {
            base.PrintInfo(book);
        }
    }
}