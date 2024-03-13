using Microsoft.AspNetCore.Mvc;
using BookShop.Models;
using BookShop.ViewModels;

namespace BookShop.Services
{
    public interface IBookService
    {
        Task<ActionResult<IEnumerable<BookViewModel>>> GetBooks();

        Task<ActionResult<BookViewModel>> PostBook(BookViewModel book);
    }
}
