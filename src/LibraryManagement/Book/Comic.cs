using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class Comic:Book,IBorrowable
    {

    private Library _Library;
    public Comic(int isbn, string title, string author, DateOnly pubDate, bool canBorrow, bool CanPrint, string artist,Library library)
        : base(isbn, title, author, pubDate, canBorrow, CanPrint)
    {
        _Library=library;
        Artist = artist;
    }        
        private string Artist{get; set;}

        public void BorrowBook(Book book)
        {
            Book foundBook=_Library.FindBook(book.ISBN);
            if(foundBook==null){
                Console.WriteLine("Book not found");
            }
            else{
                _Library.BorrowBook(book);
            }

        }

        public void ReturnBook(Book book)
        {
                _Library.ReturnBook(book); 
        }
        public override void PrintInfo(Book book)
        {
            base.PrintInfo(book);
        }
    }
}