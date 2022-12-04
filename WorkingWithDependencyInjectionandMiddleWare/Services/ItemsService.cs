using WorkingWithDependencyInjectionandMiddleWare.Models;

namespace WorkingWithDependencyInjectionandMiddleWare.Services
{

    public class ItemsService : IItemsService
    {
        private List<Items> _items;

        public ItemsService()
        {
            _items = new List<Items>()
            {

            };

        }
        public async Task AddItems(Items product)
        {
            _items.Add(product);
        }

        public int GetItems()
        { 
            return _items.Count();
        }
    }
}
