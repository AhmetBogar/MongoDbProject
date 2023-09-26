using MongoDbProject.Models;

namespace MongoDbProject.Services.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(string id);
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(string id);
    }
}
