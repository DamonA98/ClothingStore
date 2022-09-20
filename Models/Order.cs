namespace ClothingStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        
        public List<OrderDetail>? OrderDetails { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string AddressLine1 { get; set; } = String.Empty;
        public string? AddressLine2 { get; set; } 
        public string ZipCode { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string? State { get; set; }
        public string Country { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; } 
    }
}

