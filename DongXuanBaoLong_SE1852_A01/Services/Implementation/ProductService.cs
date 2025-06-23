using BussinessObject;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository) { 
            this.productRepository = productRepository;
        }

        public int AddProduct(Product product)
        {
            return productRepository.AddProduct(product);
        }

        public bool DeleteProduct(int productID)
        {
            return productRepository.DeleteProduct(productID);
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }

        public Product? GetProductByID(int productID)
        {
            return productRepository.GetProductByID(productID);
        }

        public List<Product> SearchProductsByName(string name)
        {
            return productRepository.GetProductsByName(name);
        }

        public bool UpdateProduct(Product product)
        {
            return productRepository.UpdateProduct(product);
        }
    }
}
