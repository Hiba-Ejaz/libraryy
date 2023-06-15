using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class Novel:Book, IBorrowable
    {
        public Novel(int isbn, string title, string author, DateOnly pubDate, bool canBorrow, bool canPrint,string genre)
            : base(isbn, title, author, pubDate, canBorrow, canPrint)
        {
            Genre=genre;
        }
        private string Genre{get; set;}

        public void BorrowBook(Book book)
        {
           Console.WriteLine("inside Novel BorrowBook");
        }
        

        public void ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }
         public override void PrintInfo(Book book)
        {
            base.PrintInfo(book);
        }
    }
}