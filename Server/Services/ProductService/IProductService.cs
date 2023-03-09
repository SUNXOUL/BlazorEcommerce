using Ecommerce.Client.Pages;
using Ecommerce.Shared;

namespace Ecommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Producto>>> GetAllProductsAsync();
        Task<ServiceResponse<Producto>> GetProductsAsync(int Id);
    }
}
