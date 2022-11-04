using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IProductService
    {
        IQueryable<Product> GetProducts();
        Product? GetProductById(int productId);
        IQueryable<Product> GetProductByName(string name = null);
        IQueryable<Product> GetProductsByPriceAscending();
        IQueryable<Product> GetProductsByPriceDescending();

        User? GetUser();
    }
}
