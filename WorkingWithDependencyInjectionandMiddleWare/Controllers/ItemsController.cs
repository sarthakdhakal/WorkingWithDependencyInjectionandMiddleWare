using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkingWithDependencyInjectionandMiddleWare.Models;
using WorkingWithDependencyInjectionandMiddleWare.Services;

namespace WorkingWithDependencyInjectionandMiddleWare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsService _itemsService;
        public ItemsController(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }
        // GET: api/<DISampleControllerController>
        [HttpGet]
        public int Get()
        {
            return _itemsService.GetItems();
        }

        [HttpPost]
        public int Post([FromBody] Items items)
        {
            _itemsService.AddItems(items);
            return _itemsService.GetItems();

        }
    }
}
