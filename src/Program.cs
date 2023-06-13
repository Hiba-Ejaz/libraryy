using src.LibraryManagement;
Library library=new Library();
var comicBook = new Comic(12, "Comic Title", "Comic Author", new DateOnly(2022, 1, 1), true, true,"Hiba Ejaz");
Librarian librarian=new Librarian("Mr Chips",1,library);
librarian.AddBook(comicBook);
var textBook = new TextBook(12, "text Title 2", "text Author 2", new DateOnly(2023, 1, 1), true, true);
librarian.AddBook(textBook);