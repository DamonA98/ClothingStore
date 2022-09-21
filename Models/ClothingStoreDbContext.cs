using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Models
{
    public class ClothingStoreDbContext: IdentityDbContext
    {
        public ClothingStoreDbContext(DbContextOptions<ClothingStoreDbContext>options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Sneakers> Sneakers { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
