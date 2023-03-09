using Ecommerce.Shared;

namespace Ecommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categorias { get; set; }
        Task GetCategorys();
        Task<ServiceResponse<Category>> GetCategory(int ID);
    }
}
