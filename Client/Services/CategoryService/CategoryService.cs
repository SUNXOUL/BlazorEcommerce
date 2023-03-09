using Ecommerce.Client.Pages;
using Ecommerce.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Ecommerce.Client.Services.CategoryService
{

    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            this._http = http;
        }

        public List<Category> Categorias { get; set; } = new List<Category>();

        public async Task GetCategorys()
        {
            var resultado = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (resultado != null && resultado.Data != null)
            {
                Categorias = resultado.Data;
            }
            else
            {
                Console.WriteLine("NoFoundList");
            }
        }

        public async Task<ServiceResponse<Category>> GetCategory(int ID)
        {
            var resultado = await _http.GetFromJsonAsync<ServiceResponse<Category>>($"api/Category/{ID}");
                return  resultado;

        }
    }
}
