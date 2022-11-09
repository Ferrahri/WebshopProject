using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Dto;

namespace ServiceLayer.Products
{
    public class ProductService : IProductService
    {

        public DataLayer.ShopContext _ctx;

        public ProductService(ShopContext context)
        {
            _ctx = context;
        }



        public Task<ProductDto> GetProductAsync(int id)
        {
            return _ctx.Products
                            .Where(p => p.ProductId == id)
                            .ToDto()
                            .FirstOrDefaultAsync();
        }



        public async Task<List<ProductDto>> GetProductsAsync()
        {
            return await _ctx.Products
                .ToDto()
                .ToListAsync();
        }

        public Task CreateProductAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task EditProductAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductImageDto> GetProductImageAsync(int productId, int ImageNumber)
        {
            throw new NotImplementedException();
        }
        //basic search, can only search by PRODUCT NAME only for now, brand later
        //public IQueryable<Product> GetProductByName(string? name = null)
        //{
        //    return _context.Products
        //        .Include(b => b.Brand)
        //        .Where(r => string.IsNullOrEmpty(name) || r.Name.StartsWith(name))
        //        .OrderBy(r => r.Name);
        //}
    }
}
