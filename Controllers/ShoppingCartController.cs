using ClothingStore.Models;
using ClothingStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISneakersRepository _sneakersRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(ISneakersRepository sneakersRepository, IShoppingCart shoppingCart)
        {
            _sneakersRepository = sneakersRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart,
                _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int sneakerId)
        {
            var selectedSneaker = _sneakersRepository.AllSneakers.FirstOrDefault(p => p.SneakersId == sneakerId);

            if(selectedSneaker != null)
            {
                _shoppingCart.AddToCart(selectedSneaker);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int sneakersId)
        {
            var selectedSneaker = _sneakersRepository.AllSneakers.FirstOrDefault(
                p => p.SneakersId == sneakersId);

            if(selectedSneaker != null)
            {
                _shoppingCart.RemoveFromCart(selectedSneaker);
            }
            return RedirectToAction("Index");
        }
    }
}
