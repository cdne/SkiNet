using Microsoft.AspNetCore.Mvc;

namespace SkiNet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "list of products";
        }

        [HttpGet("{product}")]
        public string GetProduct(string product)
        {
            return $"single product {product}";
        }
    }
}