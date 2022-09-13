using ClothingStore.Models;
using ClothingStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SampleApplication.Models;
using System.Diagnostics;

namespace SampleApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISneakersRepository _sneakersRepository;

        public HomeController(ISneakersRepository sneakersRepository)
        {
            _sneakersRepository = sneakersRepository;
        }

        public IActionResult Index()
        {
            var sneakersofTheWeek = _sneakersRepository.IsSneakersofTheWeek;
            var homeViewModel = new HomeViewModel(sneakersofTheWeek);
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}