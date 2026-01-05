using Microsoft.AspNetCore.Mvc;
using Products.Data;
using Products.Data.Extensions;
using Products.Models;

namespace Products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetMinMaxValue(float minValue,
            float maxValue)
        {
            var result = _context
                .Products
                .GetAllProducts(minValue, maxValue);
                //.GetProducts(minValue, maxValue);
            if (result.Count <= 0) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Created();
        }
    }
}
