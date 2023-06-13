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
    public class Library:ICustomerActions,ILibrarianActions
    {
        public Library(){

        }
        private List<Person> people=new List<Person>();
        private List<Book> books=new List<Book>();

        public void AddPerson(Person person){

        }
        public void RemovePerson(Person person){
            
        }
        public void EditPerson(Person person){
            
        }

        public void BorrowBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            if(book!=null){
           bool isBookUnique=books.Exists(b=>b.ISBN==book.ISBN);
            if (!isBookUnique)
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
            throw new NotImplementedException();
        }
    }
}