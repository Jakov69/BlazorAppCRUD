//using BlazorAppOluja.Client.Shared;

//namespace BlazorAppOluja.Client.Services.ProductService
//{
//    public interface IProductService
//    {
//        event Action ProductChanged;
//        List<Product> Products { get; set; }

//        Task GetProducts(string? categoryUrl = null);
//        Task<ServiceResponse<Product>> GetProduct(int productId);


//    }
//}
using BlazorAppOluja.Client.Shared;
using System;

namespace BlazorAppOluja.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductChanged; // Add this line
        List<Product> Products { get; set; }

        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}

