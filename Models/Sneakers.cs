namespace ClothingStore.Models
{
    public class Sneakers
    {
        
        public int SneakersId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Description  { get; set; }
        public int Size { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailURL { get; set; }
        public string? Color   { get; set; }
        public bool IsSneakersofTheWeek { get; set; }
        public Category Category { get; set; } = default!;
        


    }
}
