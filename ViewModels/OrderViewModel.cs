using Rental.Models;

namespace Rental.ViewModels
{
    public class OrderViewModel
    {
        public string OrderId {  get; set; }
        
        public ICollection<OrderLineViewModel> OrderLines { get; set; } = new List<OrderLineViewModel>();
    }
}
