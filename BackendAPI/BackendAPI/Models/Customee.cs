namespace BackendAPI.Models
{

    public enum CustomerStatus
    {
        Active,
        Inactive,
        Pending
    }

    public class Customee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public CustomerStatus Status { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsVip { get; set; }
    }
}
