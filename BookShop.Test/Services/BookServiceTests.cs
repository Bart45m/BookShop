using BookShop.Data;
using BookShop.Models;
using BookShop.Services;
using BookShop.Test.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BookShop.ViewModels;

namespace BookShop.Test.Services
{
    public class BookServiceTests
    {
        [Fact]
        public async Task GetBooks_ReturnsBookList_WhenContextIsNotNull()
        {
            //Arrange
            var BookList = new List<Book>();
            for (var i = 0; i < 10; i++)
                BookList.Add(new Book() { Id = i + 1, Bookstand = i + 1, Price = "" + i + 1, Shelf = i + 1, Title = "title" + i + 1 });
            
            var mockedContext = new Mock<BookShopDbContext>();
            mockedContext.Setup(x => x.Books).ReturnsDbSet(BookList);

            var bookService = new BookService(mockedContext.Object);

            //Act
            var result = await bookService.GetBooks();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(10, result.Count());
        }

        [Fact]
        public async Task GetBooks_ThrowsException_WhenContextIsNull()
        {
            //Arrange
            var mockedContext = new Mock<BookShopDbContext>();
            //mockedContext.Setup(x => x.Books).ReturnsDbSet();//ReturnsDbSet(BookList);

            var bookService = new BookService(mockedContext.Object);

            //Act
            Func<Task> act = async () => await bookService.GetBooks();

            //Assert
            Exception ex = await Assert.ThrowsAsync<Exception>(act);
            Assert.Equal("_contex.Books is null", ex.Message);
        }

        [Fact]
        public async Task PostBook_ReturnsBook_WhenContextIsNotNull()
        {
            //Arrange
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

            var BookList = new List<Book>();
            BookList.Add(new Book() { Id = 1, Bookstand = 1, Price = "price", Shelf = 1, Title = "title" });

            var mockedContext = new Mock<BookShopDbContext>();
            mockedContext.Setup(x => x.Books).ReturnsDbSet(BookList);//ReturnsDbSet(BookList);

            var bookService = new BookService(mockedContext.Object);

            //Act
            var result = await bookService.PostBook(bookToCreate);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(bookToCreate, result);
        }

        [Fact]
        public async Task PostBook_ReturnsBook_WhenContextIsNull()
        {
            //Arrange
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

            var mockedContext = new Mock<BookShopDbContext>();
            var bookService = new BookService(mockedContext.Object);

            //Act
            Func<Task> act = async () => await bookService.PostBook(bookToCreate);

            //Assert
            Exception ex = await Assert.ThrowsAsync<Exception>(act);
            Assert.Equal("Entity set 'RentalDbContext.Books'  is null.", ex.Message);
        }
    }
}
