using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartEventController : BaseCRUDController<CartEventBrojIndeksaRESPONSE, CartEventBrojIndeksaSOBJ, CartEventBrojIndeksaREQUEST, CartEventBrojIndeksaREQUEST>
    {
        protected readonly ICartEventService _service;
        public CartEventController(ICartEventService service) : base(service)
        {
            _service = service;
        }
    }
}
