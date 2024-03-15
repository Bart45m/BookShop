using BookShop.Controllers;
using BookShop.Models;
using BookShop.Services;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Test.Controllers
{
    public class BookControllerTests
    {
        [Fact]
        public async Task GetBooks_ReturnsOkResult_WithListOfBooks()
        {
            // Arrange
            var mockBookService = new Mock<IBookService>();

            var expectedBooks = new List<BookViewModel>
            {
                new BookViewModel { 
                    Id = 1, Title = "Book 1", Authors = new List<AuthorViewModel>() { new AuthorViewModel()
                    {
                        FirstName = "FirstName1",
                        LastName = "LastName1"
                    } }
                },
                new BookViewModel { 
                    Id = 2, Title = "Book 2", Authors = new List<AuthorViewModel>() { new AuthorViewModel()
                    {
                        FirstName = "FirstName2",
                        LastName = "LastName2"
                    } }
                }
            };

            mockBookService.Setup(service => service.GetBooks()).ReturnsAsync(expectedBooks);
            var controller = new BooksController(mockBookService.Object);

            // Act
            var result = await controller.GetBooks();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var actualBooks = Assert.IsType<List<BookViewModel>>(okResult.Value);
            Assert.Equal(expectedBooks.Count(), actualBooks.Count());
            Assert.Equal(expectedBooks, actualBooks);
        }

        [Fact]
        public async Task GetBooks_ReturnsProblemResult()
        {
            // Arrange
            var mockBookService = new Mock<IBookService>();
            mockBookService.Setup(service => service.GetBooks()).Throws(new Exception());
            var controller = new BooksController(mockBookService.Object);

            // Act
            var result = await controller.GetBooks();

            // Assert
            var okResult = Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task PostBook_ReturnsOkResult_WithBook()
        {
            // Arrange
            var mockBookService = new Mock<IBookService>();
            var bookToCreate = new BookViewModel
            {
                Id = 1,
                Title = "Book 1",
                Authors = new List<AuthorViewModel>() { new AuthorViewModel()
                    {
                        FirstName = "FirstName1",
                        LastName = "LastName1"
                    } }
            };

            var controller = new BooksController(mockBookService.Object);

            // Act
            var result = await controller.PostBook(bookToCreate);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var createdBook = Assert.IsType<BookViewModel>(okResult.Value);
            Assert.Equal(bookToCreate.Title, createdBook.Title);
            Assert.Equal(bookToCreate.Authors, createdBook.Authors);
        }

        [Fact]
        public async Task PostBook_ReturnsProblemDetails()
        {
            // Arrange
            var mockBookService = new Mock<IBookService>();
            var bookToCreate = new BookViewModel
            {
                Id = 1,
                Title = "Book 1",
                Authors = new List<AuthorViewModel>() { new AuthorViewModel()
                    {
                        FirstName = "FirstName1",
                        LastName = "LastName1"
                    } }
            };

            mockBookService.Setup(service => service.PostBook(bookToCreate)).Throws(new Exception());
            var controller = new BooksController(mockBookService.Object);

            // Act
            var result = await controller.PostBook(bookToCreate);

            // Assert
            var objectResult = Assert.IsType<ObjectResult>(result.Result);
            Assert.IsType<ProblemDetails>(objectResult.Value);
        }
    }
}
