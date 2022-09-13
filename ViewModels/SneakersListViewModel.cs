using ClothingStore.Models;
namespace ClothingStore.ViewModels
{
    public class SneakersListViewModel
    {
        public IEnumerable<Sneakers> Sneakers { get; }
        public string? CurrentCategory { get; }

        public SneakersListViewModel(IEnumerable<Sneakers> sneakers, string? currentCategory)
        {
            Sneakers = sneakers;
            CurrentCategory = currentCategory;
        }
    }
}
