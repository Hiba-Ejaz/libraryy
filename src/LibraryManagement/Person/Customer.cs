using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Customer can Borrow and Return books.
// Librarian can Add, Remove, Edit books.

namespace src.LibraryManagement
{
    public class Customer : Person, ICustomerActions
    {
        private Library _Library;
        public Customer(string name, int id, Library library) : base(name, id)
        {
            this._Library = library;
        }
        public void BorrowBook(Book book)
        {
            if (book is IBorrowable borrowableBook) //dynamic polymorphism (infers type of book and checks if it implements IBorrowable, if yes, assigns it to variable (borrowableBook)) 
            {
                borrowableBook.BorrowBook(book);
            }
        }

        public void ReturnBook(Book book)
        {
            if (book is IBorrowable returnBook) //dynamic polymorphism (infers type of book and checks if it implements IBorrowable, if yes, assigns it to variable (borrowableBook)) 
            {
                returnBook.ReturnBook(book);
            }
        }
    }
}