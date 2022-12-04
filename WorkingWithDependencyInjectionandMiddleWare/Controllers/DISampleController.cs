using Microsoft.AspNetCore.Mvc;
using WorkingWithDependencyInjectionandMiddleWare.Models;
using WorkingWithDependencyInjectionandMiddleWare.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkingWithDependencyInjectionandMiddleWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DISampleController : ControllerBase
    {
        private readonly ICartService _cartService;
        public DISampleController(ICartService cartService)
        {
            _cartService = cartService;
        }
        // GET: api/<DISampleControllerController>
        [HttpGet]
        public int Get()
        {
            return _cartService.GetCartAsync();
        }
        [HttpPost]
        public int Post([FromBody] Cart cart)
        {
            _cartService.AddToCartAsync(cart);
            return _cartService.GetCartAsync();

        }

      
    }
}
