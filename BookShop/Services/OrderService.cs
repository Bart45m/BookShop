using BookShop.Data;
using BookShop.Models;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;

namespace BookShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly BookShopDbContext _context;

        public OrderService(BookShopDbContext context) { _context = context; }

        public async Task<ActionResult<IEnumerable<OrderViewModel>>> GetOrders(int pageNumber, int pageSize)
        {
            //throw new NotImplementedException();

            /*
             select orders.OrderId, OrderLine.BookId, count(OrderLine.BookId) as Quantity from ORDERS
                INNER JOIN OrderLine ON OrderLine.OrderId = Orders.Id
                Group by Orders.Id, OrderLine.BookId
             */

            if (_context.Orders == null)
            {
                throw new Exception("_contex.Orders is null");
            }

            var results = await _context.Orders
            .Include(x => x.OrderLines)
                .OrderBy(x => x.Id)
                .Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .Select(x => new OrderViewModel(x))
                .AsNoTracking()
                .ToListAsync();

            return results;
        }

        /*public async Task<ActionResult<IEnumerable<OrderQueryObject>>> GetOrdersRawSQL(int pageNumber, int pageSize)
        {

            if (_context.OrderQueryObjects == null)
            {
                throw new Exception("_contex.Orders is null");
            }

            var results = await _context.OrderQueryObjects
                .FromSqlInterpolated($@"
                    SELECT o.Id as Id, o.OrderId as OrderId, 
                           ol.Id AS OrderLineId, ol.BookId as OrderLineBookId, ol.OrderId AS OrderId, 
                           COUNT(ol.Id) AS Quantity
                    FROM Orders o
                    INNER JOIN OrderLines ol ON o.Id = ol.OrderId
                    GROUP BY o.Id, o.OrderId, ol.Id, ol.BookId, ol.OrderId
                    ORDER BY o.Id
                    OFFSET {pageSize * (pageNumber - 1)} ROWS FETCH NEXT {pageSize} ROWS ONLY
                ")
                .AsNoTracking()
                .Select(x => new OrderQueryObject
                {
                    OrderId = x.OrderId,
                    OrderLines = new List<OrderLineViewModel>
                    {
                        new OrderLineViewModel
                        {
                            BookId = x.OrderLineBookId,
                            Quantity = x.Quantity
                        }
                    }
                })
                .ToListAsync();

            return results;
        }*/

        //throw new NotImplementedException();

        /*
         select orders.OrderId, OrderLine.BookId, count(OrderLine.BookId) as Quantity from ORDERS
            INNER JOIN OrderLine ON OrderLine.OrderId = Orders.Id
            Group by Orders.Id, OrderLine.BookId
         */
    }
}
