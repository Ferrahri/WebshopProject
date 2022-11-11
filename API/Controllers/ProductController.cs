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


        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return NoContent();
        }


        //validation works but the post to route doesnt seem to go through
        [Route("/product/create")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto product)
        {
            try
            {
                await _ProductService.CreateProductAsync(product);
                return Ok("Create success!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditProduct(ProductDto product)
        {
            try
            {
                await _ProductService.EditProductAsync(product);
                return Ok("product edit success");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}