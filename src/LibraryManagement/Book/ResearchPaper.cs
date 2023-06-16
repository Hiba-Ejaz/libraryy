using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class ResearchPaper : Book, IPrintable
    {
        public readonly int maxPrintingLimit=3;

        public ResearchPaper(int isbn, string title, string author, DateOnly pubDate)
            : base(isbn, title, author, pubDate)
        {
        }

         public void PrintPages(int startPage,int endPage)
        {
            if(this.CanPrint)
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