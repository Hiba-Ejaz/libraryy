using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Book has properties like Title, Author, 
//ISBN, PublicationYear, CanBorrow, and CanPrint. 
//To simplify the logic, we can consider each book an unique record with unique ISBN
// in the Library. 
//In addition, Book has PrintInfo() method to print information about each book (uses Console.WriteLine).
// Comic, Novel, TextBook, and ResearchPaper should inherit properties from Book
// and have additional properties/features:
// Comic has Artist, Novel has Genre
// Comic, Novel, TextBook can be borrowed, but ResearchPaper cannot.
// If books are borrowable, they should have both Borrow() and Return() method
// TextBook, and ResearchPaper can be printed (to certain amount of pages),
// but Comic, Novel cannot.
// The PrintPages(int startPage, endPage)method uses Console.WriteLine to inform 
//the start page and end page to be printed, in case the amount of to-be-printed pages
// do not exceed the maximum allowed pages.
// Comicand Novel should have different implementations of PrintInfo() with extra 
//information about the extra properties, while TextBook, and ResearchPaper
// have default implementation.

namespace src.LibraryManagement
{
    public abstract class Book
    {
        public Book(int isbn, string title, string author, DateOnly pubDate)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublicationYear = pubDate;
            if (this is IBorrowable)
            {
                CanBorrow = true;
                Console.WriteLine("borrowable");
            }
            if (this is IPrintable)
            {
                CanPrint = true;
                Console.Write("printable");
            }
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public DateOnly PublicationYear { get; set; }
        public bool CanBorrow { get; set; }
        public bool CanPrint { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + this.Title);
            Console.WriteLine("Author: " + this.Author);
            Console.WriteLine("ISBN: " + this.ISBN);
            Console.WriteLine("Publication Year: " + this.PublicationYear);
            // Console.WriteLine("Can Borrow: " + this.);
            //Console.WriteLine("Can Print: " + CanPrint);

        }
        public virtual void PrintPages(int startPage, int endPage)
        {
            if (!(this is IPrintable printableBook))
            {
                Console.WriteLine("this book is not printable");
            }
            //Console.WriteLine(book.Title, book.ISBN, book.Author);
        }
    }

}