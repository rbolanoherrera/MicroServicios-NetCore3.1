using Lil.Products.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lil.Products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsProvider productsProvider;

        public ProductsController(IProductsProvider productsProvider)
        {
            this.productsProvider = productsProvider;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var prod = await productsProvider.GetAsync(id);

            if(prod == null)
                return NotFound();
            else
                return Ok(prod);
        }
    }
}
