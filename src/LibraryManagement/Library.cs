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

        // public override string ToString()
        // {
        //     foreach(Book b in books){
        //      return $"{b.Author}";
        //     }
        // }
        public Person FindPerson(int id)
        {
            Person foundPerson = people.Find(p => p.Id == id);
            return foundPerson;
        }
        public void AddPerson(Person person)
        {
            Person personExists = FindPerson(person.Id);
            if (personExists == null)
                people.Add(person);
            else
                Console.WriteLine("person with same id already exists");
        }
        public void RemovePerson(Person person)
        {
            Person personExists = FindPerson(person.Id);
            if (personExists == null)
                people.Remove(person);
            else
                Console.WriteLine("person doesnot exists");
        }
        public void EditPerson(Person person)
        {
            Person personExists = FindPerson(person.Id);
            if (personExists != null)
            {
                if (personExists.Id == person.Id)
                {
                    Console.WriteLine("Id cannot be updated");
                }
                personExists.Name = person.Name;
                Console.WriteLine("name has been updated");
            }
            else
                Console.WriteLine("person with same id already exists");
        }

        public Book FindBook(int isbn)
        {
            Book foundBook = books.Find(b => b.ISBN == isbn);
            return foundBook;
        }


        public void BorrowBook(Book book)
        {
            if (book != null)
            {
                borrowedBooks.Add(book);
                books.Remove(book);
                Console.WriteLine("comic book borrowed");

            }
        }
        public void ReturnBook(Book book)
        {
            if (book != null)
            {
                if (borrowedBooks.Exists(b => b.ISBN == book.ISBN))
                {
                    borrowedBooks.Remove(book);
                    books.Add(book);
                    Console.WriteLine("comic book returned");
                }
                else
                {
                    Console.WriteLine("book hasnt been borrowed");
                }
            }
        }

        public void AddBook(Book book)
        {
            if (book != null)
            {
                Book isBookUnique = FindBook(book.ISBN);
                if (isBookUnique != null)
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
                Book bookToDelete = FindBook(book.ISBN); ;
                if (bookToDelete == null)
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
        //public void EditBook(Book book,int? isbn=null,string newTitle=null,string newAuthor=null,DateOnly? newPubDate=null,string newAdditionalFeature = null)
        public void EditBook(Book book, int isbn, string newTitle, string newAuthor, DateOnly newPubDate, string newAdditionalFeature)
        {
            if (book != null)
            {
                Book bookToEdit = FindBook(book.ISBN);
                if (bookToEdit == null)
                {
                    bookToEdit = borrowedBooks.Find(b => b.ISBN == book.ISBN);
                }
                // Console.WriteLine($"book before editing :*isbn {bookToEdit.ISBN} title : {bookToEdit.Title} publicationYear :{bookToEdit.PublicationYear} author: {bookToEdit.Author} ");
                // if (bookToEdit is Comic comic)
                // {
                //     Console.WriteLine($"Artist : {comic.Artist}");
                // }
                // else if (bookToEdit is Novel novel)
                // {
                //     Console.WriteLine($"Artist : {novel.Genre}");
                // }
                if (bookToEdit == null)
                {
                    Console.WriteLine("there is no relevant book to edit");
                }
                else
                {
                    //if(isbn!=null){
                    if (bookToEdit.ISBN != isbn)
                        Console.WriteLine("isbn cannot be updated");
                    // }
                    // else if(newTitle!=null){
                    Console.WriteLine("title new one " + newTitle);
                    bookToEdit.Title = newTitle;
                    // }
                    // else if(newAuthor!=null){
                    bookToEdit.Author = newAuthor;
                    // }
                    // else if(newPubDate!=null){
                    bookToEdit.PublicationYear = newPubDate;
                    // }
                    //  else if(newAdditionalFeature!=null){
                    if (bookToEdit is Comic comicBook)
                    {
                        comicBook.Artist = newAdditionalFeature;
                    }
                    else if (bookToEdit is Novel novelBook)
                    {
                        novelBook.Genre = newAdditionalFeature;
                    }
                }
                Console.WriteLine("Book edited successfully.");
                Book bookAfterEdit = FindBook(book.ISBN);
                if (bookAfterEdit != null)
                {
                    Console.WriteLine($"book after editing :*isbn {bookToEdit.ISBN} title : {bookToEdit.Title} publicationYear :{bookToEdit.PublicationYear} author: {bookToEdit.Author} ");
                    if (bookAfterEdit is Comic comicAfterEdit)
                    {
                        Console.WriteLine($"Artist : {comicAfterEdit.Artist}");
                    }
                    else if (bookAfterEdit is Novel novelAfterEdit)
                    {
                        Console.WriteLine($"Artist : {novelAfterEdit.Genre}");
                    }
                }
            }
        }
    }
}


