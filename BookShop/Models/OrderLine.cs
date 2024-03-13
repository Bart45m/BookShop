namespace BookShop.Models
{
    public class OrderLine
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int OrderId { get; set; }

        public Book Book { get; set; } = null!;

        public Order Order { get; set; } = null!;
    }
}
