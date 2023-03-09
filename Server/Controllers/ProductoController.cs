using Ecommerce.Server.DAL;
using Ecommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Client.Pages;
using Ecommerce.Server.Services.ProductService;


namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
            private readonly IProductService productService;
            public ProductoController(IProductService productService)
            {
               this.productService = productService;
            }

            [HttpGet]
            public async Task<ActionResult<ServiceResponse<List<Producto>>>> GetProduct()
            {
                var productos = await productService.GetAllProductsAsync();
                return Ok(productos);
            }

            [HttpGet("{ID}")]
     
            public async Task<ActionResult<ServiceResponse<Producto>>> GetProduct(int ID)
            {
                var result = await productService.GetProductsAsync(ID);
                return Ok(result);
            }

    }
}

