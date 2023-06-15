using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class Librarian : Person, ILibrarianActions
    {
        private Library library;
        public Librarian(string name, int id, Library library) : base(name, id)
        {
            this.library = library;
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("nothing to add");
            }
            else
            {
                Console.WriteLine("book forwaded to library for adding in list");
                library.AddBook(book);
            }
        }

        public void RemoveBook(Book book)
        {
             if (book == null)
            {
                Console.WriteLine("nothing to delete");
            }
            else
            {
                Console.WriteLine("book forwaded to library for removing from the list");
                library.RemoveBook(book);
            }
        }
        public void EditBook(Book book,int isbn,string newTitle,string newAuthor,DateOnly newPubDate,string artist)
        {
           if (book == null)
            {
                Console.WriteLine("nothing to edit");
            }
            else
            {
                Console.WriteLine("book forwaded to library for editing");
                library.EditBook(book,isbn,newTitle,newAuthor,newPubDate,artist);

            }
        }
    }
}