using WorkingWithDependencyInjectionandMiddleWare.Models;

namespace WorkingWithDependencyInjectionandMiddleWare.Services
{
    public class CartService : ICartService
    {
        private List<Cart> _cart;
        public CartService()
        {
            _cart = new List<Cart>()
            {

            };
               
            
        }
        public async Task AddToCartAsync(Cart product)
        {
            _cart.Add(product);
           
        }
        public  int GetCartAsync()
            
        {
           return  _cart.Count();
        }
    }
}
