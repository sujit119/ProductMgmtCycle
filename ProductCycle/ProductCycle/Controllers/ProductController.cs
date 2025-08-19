using Microsoft.AspNetCore.Mvc;
using ProductCycle.Models;
using ProductCycle.Services;

namespace ProductCycle.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class ProductController : Controller
    {
        IProductServices _productService;
        public ProductController(IProductServices productServices)
        {
            _productService = productServices;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddProducts(Product product)
        {            
            return Ok(_productService.AddProduct(product));
        }
    }
}
