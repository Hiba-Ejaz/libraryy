using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class Comic:Book,IBorrowable
    {
        private string _Artist{get; set;}

        public void BorrowBook()
        {
            throw new NotImplementedException();
        }

        public void ReturnBook()
        {
            throw new NotImplementedException();
        }
    }
}