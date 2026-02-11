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
        protected readonly ICartSERVICE _service;
        public CartController(ICartSERVICE service) : base(service)
        {
            _service = service;
        }

        [HttpDelete("ClearCart/{id}")]
        public async Task ClearCart(int id)
        {
            await _service.ClearCart(id);
        }


        [HttpDelete("DeleteItem/{id}")]
        public async Task DeleteItem(int id)
        {
            await _service.DeleteItem(id);

        }

        [HttpPost("CheckOut/{id}")]
        public async Task CheckOut(int id)
        {
            await _service.CheckOut(id);

        }

    }
}
