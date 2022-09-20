using Microsoft.EntityFrameworkCore;
using ClothingStore.Models;
namespace ClothingStore.Models
{
    public class SneakersRepository: ISneakersRepository
    {
        private readonly ClothingStoreDbContext _clothingStoreDbContext;

        public SneakersRepository(ClothingStoreDbContext clothingStoreDbContext)
        {
            _clothingStoreDbContext = clothingStoreDbContext;
        }

        public IEnumerable<Sneakers> AllSneakers
        {
            get { return _clothingStoreDbContext.Sneakers.Include(c => c.Category); }
        }

        public IEnumerable<Sneakers> IsSneakersofTheWeek
        {
            get { return _clothingStoreDbContext.Sneakers.Include(c => c.Category).Where(
                p => p.IsSneakersofTheWeek); }
        }

        public Sneakers? GetSneakersById(int sneakersId)
        {
            return _clothingStoreDbContext.Sneakers.FirstOrDefault(p =>p.SneakersId == sneakersId);
        }
    }
}
