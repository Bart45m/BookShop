using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using BookShop.Models;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace BookShop.Data
{
    public partial class BookShopDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; } = null!;

        public virtual DbSet<Author> Authors { get; set; } = null!;

        public virtual DbSet<Order> Orders { get; set; } = null!;

        public virtual DbSet<OrderLine> OrderLine { get; set; } = null!;

        public virtual DbSet<User> Users { get; set; } = null!;

        public BookShopDbContext(DbContextOptions<BookShopDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("name=ConnectionStrings:DatabaseConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Authors)
                .WithOne(e => e.Book)
                .HasForeignKey(e => e.BookId)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .HasMany(e => e.OrderLines)
                .WithOne(e => e.Book)
                .HasForeignKey(e => e.BookId)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderLines)
                .WithOne(e => e.Order)
                .HasForeignKey(e => e.OrderId)
                .IsRequired();

            

            modelBuilder.Entity<User>().HasData(GetUsers());
            modelBuilder.Entity<Book>().HasData(GetBooks());
            modelBuilder.Entity<Author>().HasData(GetAuthors());
            modelBuilder.Entity<Order>().HasData(GetOrders());
            modelBuilder.Entity<OrderLine>().HasData(GetOrderLines());
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


        private static IEnumerable<User> GetUsers()
        {
            string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "users.csv" };
            var csvFilePath = Path.Combine(p);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header,
                IgnoreReferences = true,
            };

            var data = new List<User>().AsEnumerable();
            using (var reader = new StreamReader(csvFilePath))
            {
                using (var csvReader = new CsvReader(reader, config))
                {
                    data = (csvReader.GetRecords<User>()).ToList();
                }
            }

            return data;
        }

        private static IEnumerable<Author> GetAuthors()
        {
            string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "authors.csv" };
            var csvFilePath = Path.Combine(p);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header,
                IgnoreReferences = true,
            };

            var data = new List<Author>().AsEnumerable();
            using (var reader = new StreamReader(csvFilePath))
            {
                using (var csvReader = new CsvReader(reader, config))
                {
                    data = (csvReader.GetRecords<Author>()).ToList();
                }
            }

            return data;
        }

        private static IEnumerable<Book> GetBooks()
        {
            string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "books.csv" };
            var csvFilePath = Path.Combine(p);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header,
                IgnoreReferences = true,
            };

            var data = new List<Book>().AsEnumerable();
            using (var reader = new StreamReader(csvFilePath))
            {
                using (var csvReader = new CsvReader(reader, config))
                {
                    data = (csvReader.GetRecords<Book>()).ToList();
                }
            }

            return data;
        }

        private static IEnumerable<Order> GetOrders()
        {
            string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "orders.csv" };
            var csvFilePath = Path.Combine(p);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header,
                IgnoreReferences = true,
            };

            var data = new List<Order>().AsEnumerable();
            using (var reader = new StreamReader(csvFilePath))
            {
                using (var csvReader = new CsvReader(reader, config))
                {
                    data = (csvReader.GetRecords<Order>()).ToList();
                }
            }

            return data;
        }

        private static IEnumerable<OrderLine> GetOrderLines()
        {
            string[] p = { Directory.GetCurrentDirectory(), "wwwroot", "orderlines.csv" };
            var csvFilePath = Path.Combine(p);

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header,
                IgnoreReferences = true,
            };

            var data = new List<OrderLine>().AsEnumerable();
            using (var reader = new StreamReader(csvFilePath))
            {
                using (var csvReader = new CsvReader(reader, config))
                {
                    data = (csvReader.GetRecords<OrderLine>()).ToList();
                }
            }

            return data;
        }
    }
}
