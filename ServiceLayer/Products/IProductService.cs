using DataLayer.Entities;
using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Products
{
    public interface IProductService
    {
        public Task<List<ProductDto>> GetProductsAsync();

        public Task<ProductDto> GetProductAsync(int id);

        public Task CreateProductAsync(ProductDto product);

        public Task EditProductAsync(ProductDto product);

        public Task<ProductImageDto> GetProductImageAsync(int productId, int ImageNumber);
    }
}
