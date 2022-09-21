namespace ClothingStore.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly ClothingStoreDbContext _clothingStoreDbContext;

        public CategoryRepository(ClothingStoreDbContext clothingStoreDbContext)
        {
            _clothingStoreDbContext = clothingStoreDbContext;
        }

        public IEnumerable<Category> AllCategories => _clothingStoreDbContext.Categories.OrderBy(
            p => p.CategoryName);
    }
}
