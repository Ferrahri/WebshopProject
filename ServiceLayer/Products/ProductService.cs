using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Dto;

namespace ServiceLayer.Products
{
    public class ProductService : IProductService
    {

        public ShopContext _ctx;

        public ProductService(ShopContext context)
        {
            _ctx = context;
        }

        public Task<ProductDto> GetProductAsync(int id)
        {
            return _ctx.Products
                            .Where(p => p.ProductId == id)
                            .ConvertToDto()
                            .FirstOrDefaultAsync();
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            return await _ctx.Products
                .ConvertToDto()
                .ToListAsync();
        }

        public Task<ProductDto> DeleteProductAsync(int id)
        {
            // not working currently, get back to it later
            return _ctx.Products
                .Where(p => p.ProductId == id)
                .ConvertToDto()
                .FirstOrDefaultAsync();
        }


        //EDIT
        public async Task EditProductAsync(ProductDto product)
        {
            Product product_to_edit = _ctx.Products
                                .Where(p => p.ProductId == product.ProductId)
                                .FirstOrDefault();

            product_to_edit.Name = product.ProductName;
            product_to_edit.Price = product.Price;

            try
            {
                await _ctx.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Cannot make changes", e);
            }

        }

        //not implemented yet due to time constraints
        //public Task<ProductImageDto> GetProductImages()
        //{
        //    throw new NotImplementedException();
        //}


        //CREATE
        public async Task CreateProductAsync(ProductDto product)
        {
            Product new_product = new Product()
            {
                Name = product.ProductName,
                Price = product.Price
            };

            try
            {
                _ctx.Add(new_product);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Product creation unsuccessful", ex);
            }
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
