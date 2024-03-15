using BookShop.Controllers;
using BookShop.Data;
using BookShop.Models;
using BookShop.Services;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Test.Services
{
    public class OrderServiceTests
    {
        [Fact]
        public async Task GetOrders_ReturnsOrderList_WhenContextIsNotNull()
        {
            // Arrange
            var mockOrderService = new Mock<IOrderService>();

            var loadedOrderList = new List<Order>();
            for (var i = 0; i < 7; i++)
            {
                loadedOrderList.Add(new Order()
                {
                    Id = i + 1,
                    OrderId = "hash" + (i + 1),
                    User = new User
                    {
                        Id = i + 1,
                        Name = "user" + (i + 1),
                        Email = "email@email" + (i + 1) + ".com",
                        Password = "password" + (i + 1),
                        Role = 1
                    },
                    OrderLines = new List<OrderLine>()
                    {
                        new OrderLine()
                        {
                            Book = new Book
                            {
                                Id = (i + 1),
                                Title = "title"+1,
                                Price = i+"",
                                Bookstand = i,
                                Shelf = i,
                                Authors = new List<Author>() {
                                    new Author
                                    {
                                        Id = i+1,
                                        FirstName = "name"+(i+1),
                                        LastName = "surnmae"+(i+1)
                                    }
                                }
                            }
                        },
                        new OrderLine()
                        {
                            Book = new Book
                            {
                                Id = (i + 1),
                                Title = "title"+1,
                                Price = i+"",
                                Bookstand = i,
                                Shelf = i,
                                Authors = new List<Author>() {
                                    new Author
                                    {
                                        Id = i+1,
                                        FirstName = "name"+(i+1),
                                        LastName = "surnmae"+(i+1)
                                    }
                                }
                            }
                        },
                        new OrderLine()
                        {
                            Book = new Book
                            {
                                Id = i + 2,
                                Title = "title"+2,
                                Price = i+"",
                                Bookstand = i,
                                Shelf = i,
                                Authors = new List<Author>() {
                                    new Author
                                    {
                                        Id = i+2,
                                        FirstName = "name"+(i+2),
                                        LastName = "surnmae"+(i+2)
                                    }
                                }
                            }
                        }
                    }
                });
            }

            var mockedContext = new Mock<BookShopDbContext>();
            mockedContext.Setup(x => x.Orders).ReturnsDbSet(loadedOrderList);

            var orderService = new OrderService(mockedContext.Object);

            // Act
            var result = await orderService.GetOrders(1, 2);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetOrders_ThrowException_WhenContextIsNull()
        {
            //Arrange
            var mockedContext = new Mock<BookShopDbContext>();
            var orderService = new OrderService(mockedContext.Object);

            //Act
            Func<Task> act = async () => await orderService.GetOrders(2,2);

            //Assert
            Exception ex = await Assert.ThrowsAsync<Exception>(act);
            Assert.Equal("_contex.Orders is null", ex.Message);
        }
    }
}
