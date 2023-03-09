using Ecommerce.Client.Pages;
using Ecommerce.Shared;

namespace Ecommerce.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetAllCategorysAsync();
        Task<ServiceResponse<Category>> GetCategorysAsync(int Id);
    }
}
