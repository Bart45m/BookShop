using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookShop.Data;
using BookShop.Models;
using BookShop.ViewModels;

namespace BookShop.Services
{
    public class BookService : IBookService
    {
        private readonly BookShopDbContext _context;

        public BookService(BookShopDbContext context) {  _context = context; }

        public async Task<IEnumerable<BookViewModel>> GetBooks()
        {
            if (_context.Books == null)
            {
                throw new Exception("_contex.Books is null");
            }
            
            var books = await _context.Books.Include(x => x.Authors).ToListAsync();
            var fetchedBooks = books.Select(x => new BookViewModel(x)).ToList();

            return fetchedBooks;
        }

        public async Task<BookViewModel> PostBook(BookViewModel book)
        {
            if (_context.Books == null)
            {
                throw new Exception("Entity set 'RentalDbContext.Books'  is null.");
            }

            _context.Books.Add(new Book(book));
            await _context.SaveChangesAsync();

            return book;
        }
    }
}
