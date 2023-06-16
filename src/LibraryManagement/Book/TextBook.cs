using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class TextBook : Book, IBorrowable,IPrintable
    {

         public readonly int maxPrintingLimit=2;
        
        private readonly Library _Library;
        public TextBook(int isbn, string title, string author, DateOnly pubDate)
            : base(isbn, title, author, pubDate)
        {
        }
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

      public void PrintPages(int startPage,int endPage)
        {
            if(this.CanPrint){
            if(this is IPrintable printableBook){
                if(endPage-startPage<=this.maxPrintingLimit){
                    Console.WriteLine("printing");
                }
                else{
                    Console.WriteLine("max limit exceeded");
                }
            }
            else{
                Console.WriteLine("printing not allowed");
            }
            //Console.WriteLine(book.Title, book.ISBN, book.Author);
        }
        }
    }
}