using ClothingStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sneakers> IsSneakersofTheWeek { get; }
        public HomeViewModel(IEnumerable<Sneakers> sneakersofTheWeek)
        {
            IsSneakersofTheWeek = sneakersofTheWeek;
        }
    }
}
