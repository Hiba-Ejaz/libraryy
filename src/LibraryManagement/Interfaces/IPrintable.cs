using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public interface IPrintable
    {
        public void PrintPages(int startPage, int endPage);
    }
}