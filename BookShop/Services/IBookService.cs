using Microsoft.AspNetCore.Mvc;
using BookShop.Models;
using BookShop.ViewModels;

namespace BookShop.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookViewModel>> GetBooks();

        Task<BookViewModel> PostBook(BookViewModel book);
    }
}
