﻿using Ecommerce.Shared;

namespace Ecommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Producto> Productos { get; set; }
        Task GetProductos();
        Task<ServiceResponse<Producto>> GetProducto(int ID);
    }
}
