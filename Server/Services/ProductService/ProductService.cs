using Ecommerce.Client.Pages;
using Ecommerce.Server.DAL;
using Ecommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly Contexto _contexto;

        public ProductService(Contexto contexto)
        {
            this._contexto = contexto;
        }
        public async Task<ServiceResponse<Producto>> GetProductsAsync(int Id)
        {
            var response = new ServiceResponse<Producto>();
            var productos = await _contexto.Productos.FindAsync(Id);
            if (productos == null)
            {
                response.Success = false;
                response.Messagge= "este producto no existe";
            }
            else
            {
                response.Data = productos;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Producto>>> GetAllProductsAsync()
        {
            var response = new ServiceResponse<List<Producto>>()
            {
                Data = await _contexto.Productos.ToListAsync()
            };
            return response;
        }
    }
}
