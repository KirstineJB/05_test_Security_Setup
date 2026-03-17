using BackendAPI.Model;

namespace BackendAPI.Data
{
    public class OrderMock
    {

        public static List<Order> Orders => new()
        {
            new Order
            {
                Id = 1,
                UserId = 101,
                OrderNumber = "ORD-1001",
                CreatedAt = new DateTime(2026, 1, 10),
                TotalAmount = 499.95m,
                Status = OrderStatus.Delivered,
                Currency = "DKK",
                ShippingCity = "København"
            },
            new Order
            {
                Id = 2,
                UserId = 101,
                OrderNumber = "ORD-1002",
                CreatedAt = new DateTime(2026, 2, 3),
                TotalAmount = 1299.00m,
                Status = OrderStatus.Shipped,
                Currency = "DKK",
                ShippingCity = "København"
            },
            new Order
            {
                Id = 3,
                UserId = 102,
                OrderNumber = "ORD-1003",
                CreatedAt = new DateTime(2026, 2, 14),
                TotalAmount = 89.50m,
                Status = OrderStatus.Processing,
                Currency = "DKK",
                ShippingCity = "Aarhus"
            },
            new Order
            {
                Id = 4,
                UserId = 102,
                OrderNumber = "ORD-1004",
                CreatedAt = new DateTime(2026, 2, 20),
                TotalAmount = 749.00m,
                Status = OrderStatus.Pending,
                Currency = "DKK",
                ShippingCity = "Aarhus"
            },
            new Order
            {
                Id = 5,
                UserId = 103,
                OrderNumber = "ORD-1005",
                CreatedAt = new DateTime(2026, 1, 28),
                TotalAmount = 159.99m,
                Status = OrderStatus.Cancelled,
                Currency = "DKK",
                ShippingCity = "Odense"
            },
            new Order
            {
                Id = 6,
                UserId = 103,
                OrderNumber = "ORD-1006",
                CreatedAt = new DateTime(2026, 3, 1),
                TotalAmount = 2200.00m,
                Status = OrderStatus.Delivered,
                Currency = "DKK",
                ShippingCity = "Odense"
            },
            new Order
            {
                Id = 7,
                UserId = 104,
                OrderNumber = "ORD-1007",
                CreatedAt = new DateTime(2026, 3, 5),
                TotalAmount = 349.00m,
                Status = OrderStatus.Processing,
                Currency = "DKK",
                ShippingCity = "Aalborg"
            },
            new Order
            {
                Id = 8,
                UserId = 104,
                OrderNumber = "ORD-1008",
                CreatedAt = new DateTime(2026, 3, 9),
                TotalAmount = 999.95m,
                Status = OrderStatus.Pending,
                Currency = "DKK",
                ShippingCity = "Aalborg"
            }
        };
    }
}
