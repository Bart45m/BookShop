using Microsoft.AspNetCore.Mvc;
using Rental.Models;
using Rental.ViewModels;

namespace Rental.Services
{
    public interface IBookService
    {
        Task<ActionResult<IEnumerable<BookViewModel>>> GetBooks();

        Task<ActionResult<BookViewModel>> PostBook(BookViewModel book);
    }
}
