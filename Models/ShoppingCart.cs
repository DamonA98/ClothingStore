using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Models
{
    public class ShoppingCart: IShoppingCart
    {
        private readonly ClothingStoreDbContext _clothingStoreDbContext;
        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(ClothingStoreDbContext clothingStoreDbContext)
        {
            _clothingStoreDbContext = clothingStoreDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            
            ClothingStoreDbContext context = services.GetRequiredService<ClothingStoreDbContext>() ?? throw new Exception("Error Initializing");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);
            
            return new ShoppingCart(context) { ShoppingCartId = cartId};
        }

        public void AddToCart(Sneakers sneakers)
        {
            var shoppingCartItem = _clothingStoreDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Sneakers.SneakersId == sneakers.SneakersId && s.ShoppingCartId == ShoppingCartId);

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Sneakers = sneakers,
                    Amount = 1
                };
                _clothingStoreDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _clothingStoreDbContext.SaveChanges();
        }

        public int RemoveFromCart(Sneakers sneakers)
        {
            var shoppingCartItem = _clothingStoreDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Sneakers.SneakersId == sneakers.SneakersId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;
            if(shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _clothingStoreDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _clothingStoreDbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem>GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _clothingStoreDbContext.ShoppingCartItems.Where(
                s => s.ShoppingCartId == ShoppingCartId).Include(s => s.Sneakers).ToList();
        }

        public void ClearCart()
        {
            var cartItems = _clothingStoreDbContext.ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _clothingStoreDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _clothingStoreDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            decimal total = _clothingStoreDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Sneakers.Price * c.Amount).Sum();
            return total;
        }

    }
}
