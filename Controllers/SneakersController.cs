using ClothingStore.Models;
using ClothingStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Controllers
{
    public class SneakersController : Controller
    {
        private readonly ISneakersRepository _sneakersRepository;
        private readonly ICategoryRepository _categoryRepository;

        public SneakersController (ISneakersRepository sneakersRepository, ICategoryRepository categoryRepository)
        {
            _sneakersRepository = sneakersRepository;
            _categoryRepository = categoryRepository;
        }

       // public IActionResult List()
        //{
          //  SneakersListViewModel sneakersListViewModel = new SneakersListViewModel(_sneakersRepository.AllSneakers, "All Shoes");
            //return View(sneakersListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Sneakers> sneakers;
            string? currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                sneakers = _sneakersRepository.AllSneakers.OrderBy(p => p.SneakersId);
                currentCategory = "All Sneakers";
            }
            else
            {
                sneakers = _sneakersRepository.AllSneakers.Where(p => p.Category.CategoryName ==
                category).OrderBy(p => p.SneakersId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c =>
                c.CategoryName == category)?.CategoryName;
            }

            return View(new SneakersListViewModel(sneakers, currentCategory));
        }

        public IActionResult Details(int id)
        {
            var sneakers = _sneakersRepository.GetSneakersById(id);
            if (sneakers == null)
                return NotFound();
            
            return View(sneakers);

        }
    }
}
