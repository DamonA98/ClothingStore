namespace ClothingStore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int SneakersId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Sneakers Sneakers { get; set; } = default!;
        public Order Order { get; set; } = default!; 

    }
}
