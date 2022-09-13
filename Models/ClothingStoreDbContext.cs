using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Models
{
    public class ClothingStoreDbContext: DbContext
    {
        public ClothingStoreDbContext(DbContextOptions<ClothingStoreDbContext>options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Sneakers> Sneakers { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
