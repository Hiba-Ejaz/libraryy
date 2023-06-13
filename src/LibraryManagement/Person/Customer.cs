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

        public Customer(string name,int id):base(name,id){
            
        }
            public void BorrowBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}