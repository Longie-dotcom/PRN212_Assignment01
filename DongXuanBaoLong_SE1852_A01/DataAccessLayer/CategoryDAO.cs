using BussinessObject;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        private static List<Category> categories = new List<Category>();
        private static bool isInitialized = false;

        public CategoryDAO()
        {
        }

        public void Initialize()
        {
            if (isInitialized)
            {
                return;
            }

            categories.Add(new Category { CategoryID = 1, CategoryName = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" });
            categories.Add(new Category { CategoryID = 2, CategoryName = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" });
            categories.Add(new Category { CategoryID = 3, CategoryName = "Confections", Description = "Desserts, candies, and sweet breads" });
            categories.Add(new Category { CategoryID = 4, CategoryName = "Dairy Products", Description = "Cheeses" });
            categories.Add(new Category { CategoryID = 5, CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" });
            categories.Add(new Category { CategoryID = 6, CategoryName = "Meat/Poultry", Description = "Prepared meats" });
            categories.Add(new Category { CategoryID = 7, CategoryName = "Produce", Description = "Dried fruit and bean curd" });
            categories.Add(new Category { CategoryID = 8, CategoryName = "Seafood", Description = "Seaweed and fish" });

            isInitialized = true;
        }

        public List<Category> GetAllCategories()
        {
            return categories;
        }

        public Category GetCategoryByID(int categoryID)
        {
            return categories.FirstOrDefault(category => category.CategoryID == categoryID);
        }
    }
}
