using BookShop.Data;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace BookShop.Test.Data
{
    public class BookShopDbContextInMemory : DbContext
    {
        public virtual DbSet<Book> Books { get; set; } = null!;

        public virtual DbSet<Author> Authors { get; set; } = null!;

        public virtual DbSet<Order> Orders { get; set; } = null!;

        public virtual DbSet<OrderLine> OrderLines { get; set; } = null!;

        public virtual DbSet<User> Users { get; set; } = null!;

        public BookShopDbContextInMemory(DbContextOptions<BookShopDbContextInMemory> options) 
            : base(options) 
        { 

        }
    }

    public class TestFixture
    {
        public BookShopDbContext GetTestDbContext()
        {
            var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

            var options = new DbContextOptionsBuilder<BookShopDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .UseInternalServiceProvider(serviceProvider)
            .Options;

            var dbContext = new BookShopDbContext(options);

            var BookList = new List<Book>();
            for(var i = 0; i < 10; i++)
                BookList.Add(new Book() { Id = i+1, Bookstand = i+1, Price = ""+i+1, Shelf = i+1, Title = "title"+i+1 });
            dbContext.Books.AddRangeAsync(BookList);

            var UserList = new List<User>();
            for (var i = 0; i < 7; i++)
                UserList.Add(new User() { Id = i+1, Email = "email"+i+1+"@email.com", Name="name"+i+1, Password="password"+i+1, Role=1 });
            dbContext.Users.AddRangeAsync(UserList);

            var AuthorList = new List<Author>();
            for (var i = 0; i < 20; i++)
                AuthorList.Add(new Author() { Id = i+1, BookId = i >= 10 ? (i - 10) + 1 : i + 1, FirstName = "name" + i+1, LastName = "surname" + i+1 });
            dbContext.Authors.AddRangeAsync(AuthorList);

            var OrderList = new List<Order>();
            for(var i = 0; i < 7; i++)
                OrderList.Add(new Order() { Id = i+1, OrderId = "hash" + i+1, UserId = i + 1 });
            dbContext.Orders.AddRangeAsync(OrderList);

            int[,] values = new int[100, 3]
            {
                {1,1,1}, {2,1,1}, {3,1,1}, {4,1,1}, {5,1,1}, {6,2,1}, {7,2,1}, {8,2,1}, {9,2,1}, {10,2,1} ,
                {11,3,1}, {12,3,1}, {13,3,1}, {14,3,1}, {15,3,1}, {16,4,2}, {17,4,2}, {18,4,2}, {19,4,2}, {20,4,2} ,
                {21,5,2}, {22,5,2}, {23,5,2}, {24,5,2}, {25,5,2}, {26,6,2}, {27,6,2}, {28,6,2}, {29,6,2}, {30,6,2} ,
                {31,7,3}, {32,7,3}, {33,7,3}, {34,7,3}, {35,7,3}, {36,8,3}, {37,8,3}, {38,8,3}, {39,8,3}, {40,8,3} ,
                {41,9,3}, {42,9,3}, {43,9,3}, {44,9,3}, {45,9,3}, {46,10,4}, {47,10,4}, {48,10,4}, {49,10,4}, {50,10,4} ,
                {51,1,4}, {52,1,4}, {53,1,4}, {54,1,4}, {55,1,4}, {56,2,4}, {57,2,4}, {58,2,4}, {59,2,4}, {60,2,4} ,
                {61,3,5}, {62,3,5}, {63,3,5}, {64,3,5}, {65,3,5}, {66,4,5}, {67,4,5}, {68,4,5}, {69,4,5}, {70,4,5} ,
                {71,5,5}, {72,5,5}, {73,5,5}, {74,5,5}, {75,5,5}, {76,6,6}, {77,6,6}, {78,6,6}, {79,6,6}, {80,6,6} ,
                {81,7,6}, {82,7,6}, {83,7,6}, {84,7,6}, {85,7,6}, {86,8,6}, {87,8,6}, {88,8,6}, {89,8,6}, {90,8,6} ,
                {91,9,7}, {92,9,7}, {93,9,7}, {94,9,7}, {95,9,7}, {96,10,7}, {97,10,7}, {98,10,7}, {99,10,7}, {100,10,7}
            };

            var OrderLineList = new List<OrderLine>();
            for(var i = 0; i < 10; i++)
                OrderLineList.Add(new OrderLine() { Id = values[i,0], BookId = values[i,1], OrderId = values[i,2] });

            dbContext.OrderLines.AddRangeAsync(OrderLineList);

            return dbContext;
        }
    }
}
