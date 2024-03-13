namespace Rental.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string OrderId { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public int UserId { get; set; }

        public User User { get; set; } = null!;
    }
}
