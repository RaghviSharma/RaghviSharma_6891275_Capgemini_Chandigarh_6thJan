namespace EcommerceApp.Models
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class CreateOrderDto
    {
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public List<OrderItemDto> Items { get; set; } = new();
    }
}