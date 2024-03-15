using BookShop.Models;
using System.Linq;

namespace BookShop.ViewModels
{
    public class OrderViewModel
    {
        public string OrderId {  get; set; }
        
        public ICollection<OrderLineViewModel> OrderLines { get; set; } = new List<OrderLineViewModel>();

        public OrderViewModel() { }

        public OrderViewModel(Order order)
        {
            OrderId = order.OrderId;

            int[] bookIds = order.OrderLines.Select(x => x.BookId).Distinct().ToArray();
            foreach (var bookId in bookIds)
            {
                OrderLines.Add(new OrderLineViewModel(
                    bookId, order.OrderLines.Where(x => x.BookId == bookId).Count()));
            }
        }
    }
}
