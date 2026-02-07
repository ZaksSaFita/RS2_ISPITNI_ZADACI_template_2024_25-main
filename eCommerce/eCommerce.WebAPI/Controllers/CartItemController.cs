using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : BaseCRUDController<CartItemRESPONSE, CartItemSOBJ, CartItemREQUST, CartItemREQUST>
    {
        protected readonly ICartItemService _service;
        public CartItemController(ICartItemService service) : base(service)
        {
            _service = service;
        }
    }
}
