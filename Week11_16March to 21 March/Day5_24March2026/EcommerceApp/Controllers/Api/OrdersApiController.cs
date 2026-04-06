using EcommerceApp.Data;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderItems).ThenInclude(oi => oi.Product)
                .Include(o => o.ShippingDetail)
                .ToListAsync();

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.OrderItems).ThenInclude(oi => oi.Product)
                .Include(o => o.ShippingDetail)
                .FirstOrDefaultAsync(o => o.OrderId == id);

            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderDto model)
        {
            if (model == null || model.Items == null || model.Items.Count == 0)
            {
                return BadRequest("Order payload is required and must have at least one item");
            }

            var customer = await _context.Customers.FindAsync(model.CustomerId);
            if (customer == null) return BadRequest("Customer not found");

            var order = new Order
            {
                CustomerId = model.CustomerId,
                OrderDate = DateTime.UtcNow
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            foreach (var item in model.Items)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                if (product == null)
                {
                    return BadRequest($"Product with id {item.ProductId} not found");
                }

                var orderItem = new OrderItem
                {
                    OrderId = order.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                _context.OrderItems.Add(orderItem);
            }

            var shipping = new ShippingDetail
            {
                OrderId = order.OrderId,
                Address = model.Address,
                Status = "Pending"
            };

            _context.ShippingDetails.Add(shipping);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = order.OrderId }, order);
        }
    }
}