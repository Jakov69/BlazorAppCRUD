using BlazorAppOluja.Client.Shared;

namespace BlazorAppOluja.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
                return result;
        }

        public async Task GetProducts()
        {
            Console.WriteLine("Moja poruka! Uslo 1_1");

            var result =
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");

            if (result != null && result.Data != null) {
                Products = result.Data;


                Console.WriteLine($"Dohvaćeno {Products.Count} proizvoda iz baze.");
                foreach(var product in Products)
                {
                    Console.WriteLine($"Title: {product.Title}");
                }
            }
            else
            {
                Console.WriteLine("Nema dohvaćenih podataka ili dogodila se greška.");
            }
        }
    
}
}
