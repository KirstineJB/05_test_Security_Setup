using BackendAPI.Models;

namespace BackendAPI.Data
{
    public class MockCustomerData
    {
        public static List<Customee> Customers => new()
        {
            new Customee
            {
                Id = 1,
                Name = "Anna Jensen",
                City = "København",
                Status = CustomerStatus.Active,
                Email = "anna.jensen@example.com",
                CreatedAt = new DateTime(2024, 1, 15),
                IsVip = true
            },
            new Customee
            {
                Id = 2,
                Name = "Peter Hansen",
                City = "Aarhus",
                Status = CustomerStatus.Inactive,
                Email = "peter.hansen@example.com",
                CreatedAt = new DateTime(2023, 11, 2),
                IsVip = false
            },
            new Customee
            {
                Id = 3,
                Name = "Maria Nielsen",
                City = "Odense",
                Status = CustomerStatus.Active,
                Email = "maria.nielsen@example.com",
                CreatedAt = new DateTime(2024, 5, 9),
                IsVip = false
            },
            new Customee
            {
                Id = 4,
                Name = "Lars Sørensen",
                City = "Aalborg",
                Status = CustomerStatus.Pending,
                Email = "lars.soerensen@example.com",
                CreatedAt = new DateTime(2026, 2, 21),
                IsVip = false
            },
            new Customee
            {
                Id = 5,
                Name = "Sofie Madsen",
                City = "Esbjerg",
                Status = CustomerStatus.Active,
                Email = "sofie.madsen@example.com",
                CreatedAt = new DateTime(2024, 8, 14),
                IsVip = true
            },
            new Customee
            {
                Id = 6,
                Name = "Mikkel Pedersen",
                City = "Randers",
                Status = CustomerStatus.Inactive,
                Email = "mikkel.pedersen@example.com",
                CreatedAt = new DateTime(2023, 6, 30),
                IsVip = false
            },
            new Customee
            {
                Id = 7,
                Name = "Emma Kristensen",
                City = "København",
                Status = CustomerStatus.Pending,
                Email = "emma.kristensen@example.com",
                CreatedAt = new DateTime(2025, 4, 17),
                IsVip = false
            },
            new Customee
            {
                Id = 8,
                Name = "Jonas Larsen",
                City = "Aarhus",
                Status = CustomerStatus.Active,
                Email = "jonas.larsen@example.com",
                CreatedAt = new DateTime(2025, 1, 11),
                IsVip = false
            }
        };
    }
}
