namespace BackendAPI.Model
{

        public enum OrderStatus
        {
            Pending,
            Processing,
            Shipped,
            Delivered,
            Cancelled
        }

        public class Order
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string OrderNumber { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
            public decimal TotalAmount { get; set; }
            public OrderStatus Status { get; set; }
            public string Currency { get; set; } = "DKK";
            public string ShippingCity { get; set; } = string.Empty;
        }
}
