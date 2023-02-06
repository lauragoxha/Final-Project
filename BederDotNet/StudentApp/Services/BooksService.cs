using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Data.Models;
using StudentApp.Data.VM;

namespace StudentApp.Services
{
    public class BooksService : IBooksService
    {
        public AppDbContext _dbContext;

        public BooksService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public Book AddBook(BookVM bookVM)
        {
            var book = new Book()
            {
                Name = bookVM.Name,
                Author = bookVM.Author,
                ReleaseDate = bookVM.ReleaseDate,
                NoOfPages = bookVM.NoOfPages,
            };

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return book;
        }

        public void DeleteBookById(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(n => n.Id == id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            var allBooks = _dbContext.Books.ToList();
            return allBooks;
        }

        public Book GetBookById(int id)
        {
            var book = _dbContext.Books.Where(n => n.Id == id).FirstOrDefault();
            return book;
        }

        public Book UpdateBook(BookVM bookVM, int id)
        {
            var book = _dbContext.Books.Where(n => n.Id == id).FirstOrDefault();

            book.Name = bookVM.Name;
            book.Author = bookVM.Author;
            book.ReleaseDate = bookVM.ReleaseDate;
            book.NoOfPages = bookVM.NoOfPages;

            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();

            return book;
        }
    }
}
