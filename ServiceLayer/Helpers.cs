using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Dto;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer
{
    public static class DtoHelpers
    {
        public static IQueryable<ProductDto> ToDto(this IQueryable<Product> products)
        {
            return products
                       .Include(p => p.Brand)
                       .Include(p => p.Country)
                       .Include(p => p.Category)
                       .Include(p => p.ProductImages)
                       .Select(p => new ProductDto()
                       {
                           ProductId = p.ProductId,
                           ProductName = p.Name,
                           BrandName = p.Brand.Name,
                           Price = p.Price,
                           ProductImagePath = p.ProductImages.ImagePath,
                           Category = p.Category.Name,
                           CountryName = p.Country.Name,
                       });
        }
    }
}
