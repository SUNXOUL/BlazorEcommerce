using Ecommerce.Server.DAL;
using Ecommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Client.Pages;
using Ecommerce.Server.Services.CategoryService;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService CategoryService)
        {
            this.categoryService = CategoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategoria()
        {
            var Categorias = await categoryService.GetAllCategorysAsync();
            return Ok(Categorias);
        }

        [HttpGet("{ID}")]

        public async Task<ActionResult<ServiceResponse<Category>>> GetCategoria(int ID)
        {
            var result = await categoryService.GetCategorysAsync(ID);
            return Ok(result);
        }

    }
}

