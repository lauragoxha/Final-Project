using StudentApp.Data.Models;
using StudentApp.Data.VM;

namespace StudentApp.Services
{
    public interface IBooksService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book AddBook(BookVM bookVM);
        void DeleteBookById(int id);
        Book UpdateBook(BookVM bookVM, int id);
    }
}
