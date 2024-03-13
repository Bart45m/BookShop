using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Models;
using Rental.ViewModels;

namespace Rental.Services
{
    public class BookService : IBookService
    {
        private readonly RentalDbContext _context;

        public BookService(RentalDbContext context) {  _context = context; }

        public async Task<ActionResult<IEnumerable<BookViewModel>>> GetBooks()
        {
            if (_context.Books == null)
            {
                throw new Exception("_contex.Books is null");
            }
            
            var books = await _context.Books.Include(x => x.Authors).ToListAsync();
            var fetchedBooks = books.Select(x => new BookViewModel(x)).ToList();

            return fetchedBooks;
        }

        public async Task<ActionResult<BookViewModel>> PostBook(BookViewModel book)
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
