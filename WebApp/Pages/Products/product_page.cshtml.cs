using DataLayer.Entities;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Products;

namespace WebApp.Pages.Products
{
    public class ProductModel : PageModel
    {
        public IEnumerable<Product> Products { get; set; }

        private readonly IProductService _productService;

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; }

        public ProductModel(IProductService productService)
        {
            _productService = productService;
        }

        //public void OnGet()
        //{
        //    Products = _productService.GetProductByName(SearchQuery).AsNoTracking();
        //}

    }
}