using BussinessObject;

namespace Repositories.Interface
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product? GetProductByID(int productID);
        int AddProduct(Product product);
        bool DeleteProduct(int productID);
        bool UpdateProduct(Product product);
        List<Product> GetProductsByName(string name);
    }
}
