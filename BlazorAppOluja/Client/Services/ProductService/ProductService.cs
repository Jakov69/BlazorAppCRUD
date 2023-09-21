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

        public event Action ProductChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            Console.WriteLine("Moja poruka! Uslo 1_1");

            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");

            if (result != null && result.Data != null)
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


        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;

            ProductChanged.Invoke();
        }
    }
}
