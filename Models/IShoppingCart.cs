namespace ClothingStore.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Sneakers sneakers);
        int RemoveFromCart(Sneakers sneakers);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
