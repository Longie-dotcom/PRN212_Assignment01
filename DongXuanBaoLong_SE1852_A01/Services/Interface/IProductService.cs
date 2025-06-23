using BussinessObject;

namespace Services.Interface
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product? GetProductByID(int productID);
        int AddProduct(Product product);
        bool DeleteProduct(int productID);
        bool UpdateProduct(Product product);
        List<Product> SearchProductsByName(string name);
    }
}
