using BussinessObject;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private ProductDAO productDAO;

        public ProductRepository()
        {
            productDAO = new ProductDAO();
            productDAO.Initialize();
        }

        public int AddProduct(Product product)
        {
            return productDAO.AddProduct(product);
        }

        public bool DeleteProduct(int productID)
        {
            return productDAO.DeleteProduct(productID);
        }

        public List<Product> GetAllProducts()
        {
            return productDAO.GetAllProducts();
        }

        public Product? GetProductByID(int productID)
        {
            return productDAO.GetProductByID(productID);
        }

        public bool UpdateProduct(Product product)
        {
            return productDAO.UpdateProduct(product);
        }

        public List<Product> GetProductsByName(string name)
        {
            return productDAO.GetProductsByName(name);
        }
    }
}
