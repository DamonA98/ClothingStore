namespace ClothingStore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Basketball Shoes"},
                 new Category{CategoryId = 2, CategoryName = "Running Shoes"},
                  new Category{CategoryId = 3, CategoryName = "LifeStyle Shoes"}
            };
    }
}
