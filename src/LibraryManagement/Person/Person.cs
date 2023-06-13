using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Person has properties such as Name and ID. Customer and Librarian should inherit from this class and have additional properties/features:
// Customer can Borrow and Return books.
// Librarian can Add, Remove, Edit books.
namespace src.LibraryManagement
{
    public abstract class Person
    {
     private string _Name;
     private readonly int _Id;   
    }
}