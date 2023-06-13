using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public interface IBorrowable
    {
        public void BorrowBook();
        public void ReturnBook();
    }
}