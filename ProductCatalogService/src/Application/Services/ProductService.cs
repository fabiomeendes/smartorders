using ProductCatalogService.Domain.Entities;

namespace ProductCatalogService.Application.Services
{
    public class ProductService : IProductService
    {
        public Task<Product> CreateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(string id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
