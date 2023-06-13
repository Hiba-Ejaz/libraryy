using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class TextBook : Book, IBorrowable
    {
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