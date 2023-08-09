using BlazorAppOluja.Client.Shared;

namespace BlazorAppOluja.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
