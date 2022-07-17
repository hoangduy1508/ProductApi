using ProductApi.Entities;

namespace ProductApi.Services
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<IEnumerable<Category>> GetCategoriesAsync();

        Task<Product?> GetProductByIdAsync( int productId);

        Task AddProductAsync(Product product);

        Task<bool> SaveChangesAsync();
    }
}
