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


        [HttpPost("{id}/addToCart")]
        public virtual async Task<CartRESPONSE?> addToCart(int id, [FromBody] CartItemREQUST request)
        {
            return await _service.addToCart(id, request);
        }
    }
}
