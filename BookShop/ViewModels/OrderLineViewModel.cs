using BookShop.Models;

namespace BookShop.ViewModels
{
    public class OrderLineViewModel
    {
        public int BookId { get; set; }

        public int Quantity { get; set; }

        public OrderLineViewModel() { }

        public OrderLineViewModel(int bookId, int quantity)
        {
            BookId = bookId;
            Quantity = quantity;
        }
    }
}
