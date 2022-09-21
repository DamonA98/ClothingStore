namespace ClothingStore.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }
        public Sneakers Sneakers { get; set; }
        public int Amount { get; set; }
        public string? ShoppingCartId { get; set; }
    }
}
