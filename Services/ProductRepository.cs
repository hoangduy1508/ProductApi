using ProductApi.DbContexts;
using ProductApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProductApi.Services
{
    public class ProductRepository : IProductRepository
    {

        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {


            return await _context.Products.Include(c => c.Category).OrderBy(c => c.Id).ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.OrderBy(c => c.Id).ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int productId) {

            return await _context.Products.OrderBy(c => c.Id).Include(c => c.Category).Where(c => c.Id == productId).FirstOrDefaultAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
