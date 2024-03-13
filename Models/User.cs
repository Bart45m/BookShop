using Microsoft.Extensions.Hosting;

namespace Rental.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Role { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
