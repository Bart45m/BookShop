using BookShop.Controllers;
using BookShop.Models;
using BookShop.Services;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Test.Controllers
{
    public class OrderControllerTests
    {
        [Fact]
        public async Task GetOrders_ReturnsOkResult_WithListOfOrderViewModels()
        {
            // Arrange
            var mockOrderService = new Mock<IOrderService>();

            var expectedOrderList = new List<OrderViewModel>();
            for (var i = 0; i < 4; i++)
            {
                expectedOrderList.Add(new OrderViewModel()
                {
                    OrderId = "hash" + i + 1,
                    OrderLines = new List<OrderLineViewModel>()
                    {
                        new OrderLineViewModel()
                        {
                            BookId = i + 1,
                            Quantity = 1,
                        },
                        new OrderLineViewModel()
                        {
                            BookId = i + 2,
                            Quantity = 1
                        }
                    }
                });
            }

            mockOrderService.Setup(service => service.GetOrders(2,2)).ReturnsAsync(expectedOrderList);
            var controller = new OrderController(mockOrderService.Object);

            // Act
            var result = await controller.GetOrders(2,2);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var actualOrders = Assert.IsType<List<OrderViewModel>>(okResult.Value);
            Assert.Equal(4, actualOrders.Count());
        }

        [Fact]
        public async Task GetOrders_ReturnsNonFound()
        {
            //Arrange
            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(service => service.GetOrders(2,2)).Throws(new Exception());
            var controller = new OrderController(mockOrderService.Object);

            // Act
            var result = await controller.GetOrders(2,2);

            // Assert
            var okResult = Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}
