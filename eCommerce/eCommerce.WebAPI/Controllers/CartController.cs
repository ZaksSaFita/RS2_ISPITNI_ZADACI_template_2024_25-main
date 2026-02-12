using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : BaseCRUDController<CartRESPONSE, CartSOBJ, CartREQUEST, CartREQUEST>
    {
        protected readonly ICartService _service;
        public CartController(ICartService service) : base(service)
        {
            _service = service;
        }


        [HttpPost("addToCart")]
        public virtual async Task<CartRESPONSE?> addToCart([FromBody] CartItemREQUST request)
        {
            return await _service.addToCart(request);
        }

        [HttpDelete("removeItem/{ItemId}")]

        public async Task removeFromCart(int ItemId)
        {
            await _service.removeFromCart(ItemId);
        }

    }
}
