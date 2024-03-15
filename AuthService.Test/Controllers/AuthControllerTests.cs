using AuthService.Controllers;
using Castle.Core.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace AuthService.Test.Controllers
{
    public class AuthControllerTests
    {
        [Fact]
        public async Task GenerateToken_ReturnsOkResult()
        {
            // Arrange
            var myConfiguration = new Dictionary<string, string>
            {
               {"JwtSettings:Issuer", "valueA"},
               {"JwtSettings:Audience", "valueB"},
               {"JwtSettings:Token", "QeRzFyHvJxLzPbTdVgNcXxZoPqRyUwAsDfGhJkL"}
            };


            var conf = new ConfigurationBuilder()
                .AddInMemoryCollection(myConfiguration)
                .Build();

            var controller = new AuthController(conf);

            // Act
            var result = controller.GenerateToken(new TokenGenerationRequest
            {
                UserId = "1",
                Email = "email@email.com",
                Role = 0
            });

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.IsType<string>(okResult.Value);
        }
    }
}
