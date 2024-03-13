using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rental.Data;
using Rental.Models;
using Rental.Services;
using Rental.ViewModels;

namespace Rental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly RentalDbContext _context;

        public BooksController(IBookService bookService, RentalDbContext context)
        {
            _bookService = bookService;
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookViewModel>>> GetBooks()
        {
            try
            {
                var books = await _bookService.GetBooks();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookViewModel>> PostBook(BookViewModel book)
        {
            try { 
                await _bookService.PostBook(book);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return Problem("Entity set 'RentalDbContext.Books'  is null.");
            }
        }
    }
}
