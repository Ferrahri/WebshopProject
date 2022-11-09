using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Dto;
using ServiceLayer.Products;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public ProductController(IProductService productService)
        {
            _ProductService = productService;
        }

        [HttpGet]

        [HttpGet]
        [Route("/all")]
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _ProductService.GetProductsAsync();
        }

        [HttpGet]
        [Route("/{id}")]
        public async Task<ProductDto> GetProduct(int id)
        {
            return await _ProductService.GetProductAsync(id);
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Product>>> GetTodoItems()
        //{
        //    return await _context.Products
        //        .ToListAsync();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct(int id)
        //{
        //    var product_to_delete = await _context.Products.FindAsync(id);
        //    if (product_to_delete == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Products.Remove(product_to_delete);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        //{
        //    var product_to_get_by_id = await _context.Products.FindAsync(id);

        //    if (product_to_get_by_id == null)
        //    {
        //        return NotFound();
        //    }

        //    return product_to_get_by_id;
        //}
    }
}