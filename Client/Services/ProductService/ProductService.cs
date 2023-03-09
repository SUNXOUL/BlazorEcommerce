using Ecommerce.Client.Pages;
using Ecommerce.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace Ecommerce.Client.Services.ProductService
{

    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            this._http = http;
        }

        public List<Producto> Productos { get; set; } = new List<Producto>();

        public async Task GetProductos()
        {
            var resultado = await _http.GetFromJsonAsync<ServiceResponse<List<Producto>>>("api/Producto");
            if (resultado != null && resultado.Data != null)
            {
                Productos = resultado.Data;
            }
            else
            {
                Console.WriteLine("NoFoundList");
            }
        }
        public async Task GetProductos(int ID)
        {
            var resultado = await _http.GetFromJsonAsync<ServiceResponse<List<Producto>>>("api/Producto");

            if (resultado != null && resultado.Data != null)
            {
                Productos = resultado.Data.Where(p=>p.CategoriaID==ID).ToList();
            }
            else
            {
                Console.WriteLine("NoFoundList");
            }
        }

        public async Task<ServiceResponse<Producto>> GetProducto(int ID)
        {
            var resultado = await _http.GetFromJsonAsync<ServiceResponse<Producto>>($"api/Producto/{ID}");
                return  resultado;

        }
    }
}
