// Library should manage the collection of Book objects, and Person objects.
// This class should have following methods:
// Add, Remove, Borrow, and Return books
// Add, Remove, Edit Person objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class Library : ILibrarianActions
    {
        public Library()
        {

        }
        private List<Person> people = new List<Person>();
        private List<Book> books = new List<Book>();
        private List<Book> borrowedBooks = new List<Book>();

        public void AddPerson(Person person)
        {

        }
        public void RemovePerson(Person person)
        {

        }
        public void EditPerson(Person person)
        {

        }

        public Book FindBook(int isbn){
            Book foundBook=books.Find(b=>b.ISBN==isbn);
            return foundBook;
            }
        
      
        public void BorrowBook(Book book)
        {
            if(book!=null){
                borrowedBooks.Add(book);
                books.Remove(book);
                Console.WriteLine("comic book borrowed");

            }
        }
        public void ReturnBook(Book book)
        {
             if(book!=null){
                if(borrowedBooks.Exists(b=>b.ISBN==book.ISBN)){
                borrowedBooks.Remove(book);
                books.Add(book);
                 Console.WriteLine("comic book returned");
            }
            else{
                Console.WriteLine("book hasnt been borrowed");
            }
        }
        }

        public void AddBook(Book book)
        {
            if (book != null)
            {
                Book isBookUnique = FindBook(book.ISBN);
                if (isBookUnique!=null)
                {
                    Console.WriteLine("Book with the same ISBN already exists in the library.");
                }
                else
                {
                    books.Add(book);
                    Console.WriteLine("Book added successfully.");
                }
            }
        }

        public void RemoveBook(Book book)
        {
            if (book != null)
            {
                Book bookToDelete = FindBook(book.ISBN);;
                if (bookToDelete==null)
                {
                    Console.WriteLine("there is no relevant book to delete");
                }
                else
                {
                    books.Remove(book);
                    Console.WriteLine("Book deleted successfully.");
                }
            }
        }
    }
}