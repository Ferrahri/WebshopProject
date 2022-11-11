using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Dto;
using ServiceLayer.Products;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public ProductController(IProductService productService)
        {
            _ProductService = productService;
        }

        [Route("/{id}")]

        [HttpGet]
        public async Task<ProductDto> GetProduct(int id)
        {
            return await _ProductService.GetProductAsync(id);
        }

        [Route("/all")]
        [HttpGet]
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _ProductService.GetProductsAsync();
        }


        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduct(int id)
        //{
        //    var product_to_delete = await _ProductService.Products.FindAsync(id);
        //    if (product_to_delete == null)
        //    {
        //        return NotFound("No product with that Id was found.");
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

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto product)
        {
            try
            {
                await _ProductService.CreateProductAsync(product);
                return Ok("Product created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}