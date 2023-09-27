using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class Novel : Book, IBorrowable
    {

        public Novel(int isbn, string title, string author, DateOnly pubDate, string genre)
            : base(isbn, title, author, pubDate)
        {
            Genre = genre;
        }
        public string Genre { get; set; }
        private Library _Library;

        public void BorrowBook(Book book)
        {
            Book foundBook = _Library.FindBook(book.ISBN);
            if (foundBook == null)
            {
                Console.WriteLine("Book not found");
            }
            else
            {
                _Library.BorrowBook(book);
            }

        }

        public void ReturnBook(Book book)
        {
            _Library.ReturnBook(book);
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Genre  " + this.Genre);
        }
    }
}