using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public interface ICustomerActions
    {
         public void BorrowBook(Book book);
        public void ReturnBook(Book book);
    }
}