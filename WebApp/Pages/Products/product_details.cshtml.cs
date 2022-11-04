using DataLayer.Entities;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer.Interfaces;

namespace WebApp.Pages.Products
{
    public class InfoModel : PageModel
    {
        public Product Products { get; set; }

        private readonly IProductService _productService;

        public InfoModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet(int productId)
        {
            Products = _productService.GetProductById(productId);
        }
    }
}