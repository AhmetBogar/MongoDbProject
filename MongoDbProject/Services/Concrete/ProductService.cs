using MongoDB.Driver;
using MongoDbProject.Models;
using MongoDbProject.Services.Abstract;
using MongoDbProject.Settings;

namespace MongoDbProject.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;

        public ProductService(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
        }

        public async Task CreateProduct(Product product)
        {
            await _productCollection.InsertOneAsync(product);
        }

        public async Task DeleteProduct(string id)
        {
            var values = await _productCollection.DeleteOneAsync(x => x.ProductID == id);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var values=await _productCollection.Find(x=>true).ToListAsync();
            return values;
        }

        public async Task<Product> GetProductById(string id)
        {
            var values=await _productCollection.Find<Product>(x=>x.ProductID == id).FirstOrDefaultAsync();
            return values;
        }

        public async Task UpdateProduct(Product product)
        {
            var values = await _productCollection.FindOneAndReplaceAsync(x => x.ProductID == product.ProductID, product);
        }
    }
}
