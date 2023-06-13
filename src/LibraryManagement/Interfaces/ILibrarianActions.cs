using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public interface ILibrarianActions
    {
        public void AddBook(Book book);
        public void RemoveBook(Book book);

    }
}