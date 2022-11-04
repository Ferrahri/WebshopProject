using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Interfaces;

namespace ServiceLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly ShopContext _context;

        public ProductService(ShopContext context)
        {
            context.Database.EnsureCreated();
            _context = context;
        }

        public IQueryable<Product?> GetProducts()
        {
            return _context.Products
                .Include(b => b.Brand)
                .AsNoTracking();
        }

        public Product? GetProductById(int productId)
        {
            return _context.Products
                .Include(c => c.Category)
                .Include(c => c.Brand)
                .Include(c => c.ProductType)
                .Include(c => c.ProductImages)
                .Where(p => p.ProductId == productId)
                .FirstOrDefault();
        }

        public IQueryable<Product?> GetProductsByPriceAscending()
        {
            return _context.Products
                .OrderBy(x => x.Price);
        }
        public IQueryable<Product?> GetProductsByPriceDescending()
        {
            return _context.Products
                .OrderByDescending(x => x.Price);
        }


        //basic search, can only search by PRODUCT NAME only for now, brand later
        public IQueryable<Product> GetProductByName(string? name = null)
        {
            return _context.Products
                .Include(b => b.Brand)
                .Where(r => string.IsNullOrEmpty(name) || r.Name.StartsWith(name))
                .OrderBy(r => r.Name);
        }

        public User GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
