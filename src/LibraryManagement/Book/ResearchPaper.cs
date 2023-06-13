using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.LibraryManagement
{
    public class ResearchPaper : Book, IPrintable
    {
        public ResearchPaper(int isbn, string title, string author, DateOnly pubDate, bool canBorrow, bool canPrint)
            : base(isbn, title, author, pubDate, canBorrow, canPrint)
        {
        }
        public void PrintPages(int startPage,int endPage)
        {
            throw new NotImplementedException();
        }
    }
}