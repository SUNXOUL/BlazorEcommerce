using Ecommerce.Client.Pages;
using Ecommerce.Server.DAL;
using Ecommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly Contexto _contexto;

        public CategoryService(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public async Task<ServiceResponse<Category>> GetCategorysAsync(int Id)
        {
            var response = new ServiceResponse<Category>();
            var categorias = await _contexto.Categorias.FindAsync(Id);
            if (categorias == null)
            {
                response.Success = false;
                response.Messagge= "este producto no existe";
            }
            else
            {
                response.Data = categorias;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetAllCategorysAsync()
        {
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _contexto.Categorias.ToListAsync()
            };
            return response;
        }
    }
}
