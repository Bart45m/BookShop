using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Services
{
    public interface IOrderService
    {
        Task<ActionResult<IEnumerable<OrderViewModel>>> GetOrders(int pageNumber, int pageSize);

        //Task<ActionResult<IEnumerable<OrderQueryObject>>> GetOrdersRawSQL(int pageNumber, int pageSize);
    }
}
