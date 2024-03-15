using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data
{
    public interface IBookShopDbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderLine> OrderLines { get; set; }
        DbSet<User> Users { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
