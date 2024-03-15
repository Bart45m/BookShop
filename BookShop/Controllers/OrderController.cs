using BookShop.Services;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/Orders
        [HttpGet("{pageNumber}/{pageSize}")]
        public async Task<ActionResult<IEnumerable<OrderViewModel>>> GetOrders(int pageNumber, int pageSize)
        {
            try
            {
                var orders = await _orderService.GetOrders(pageNumber, pageSize);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        // GET: api/Orders
        /*[HttpGet("/{pageNumber}/{pageSize}")]
        public async Task<ActionResult<IEnumerable<OrderQueryObject>>> GetOrdersRawSQL(int pageNumber, int pageSize)
        {
            try
            {
                var orders = await _orderService.GetOrdersRawSQL(pageNumber, pageSize);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }*/
    }
}
