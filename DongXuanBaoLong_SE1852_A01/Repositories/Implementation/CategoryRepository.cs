using BussinessObject;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private CategoryDAO categoryDAO;

        public CategoryRepository()
        {
            categoryDAO = new CategoryDAO();
            categoryDAO.Initialize();
        }

        public List<Category> GetAllCategories()
        {
            return categoryDAO.GetAllCategories();
        }

        public Category GetCategoryByID(int categoryID)
        {
            return categoryDAO.GetCategoryByID(categoryID);
        }
    }
}
