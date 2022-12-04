using WorkingWithDependencyInjectionandMiddleWare.Models;

namespace WorkingWithDependencyInjectionandMiddleWare.Services
{
    public interface ICartService
    {
        Task AddToCartAsync(Cart product);

        int GetCartAsync();
    }
}
