using BussinessObject;

namespace Repositories.Interface
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category GetCategoryByID(int categoryID);
    }
}
