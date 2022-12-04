using WorkingWithDependencyInjectionandMiddleWare.Models;

namespace WorkingWithDependencyInjectionandMiddleWare.Services
{
    public interface IItemsService
    {
        Task AddItems(Items product);

        int GetItems();
    }
}
