
namespace ClothingStore.Models
{
    public class OrderRepository : IOrderRepository
    {
        
        private readonly IShoppingCart _shoppingCart;
        private readonly ClothingStoreDbContext _clothingStoreDbcontext;

        public OrderRepository(IShoppingCart shoppingCart, ClothingStoreDbContext clothingStoreDbcontext)
        {
            _shoppingCart = shoppingCart;
            _clothingStoreDbcontext = clothingStoreDbcontext;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach(ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderdetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    SneakersId = shoppingCartItem.Sneakers.SneakersId,
                    Price = shoppingCartItem.Sneakers.Price
                };

                order.OrderDetails.Add(orderdetail);
            }

            _clothingStoreDbcontext.Orders.Add(order);

            _clothingStoreDbcontext.SaveChanges();
        }
    }
}
