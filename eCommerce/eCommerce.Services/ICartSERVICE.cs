using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;

namespace eCommerce.Services
{
    public interface ICartSERVICE : ICRUDService<CartRESPONSE, CartSOBJ, CartREQUEST, CartREQUEST>
    {
        public Task DeleteItem(int id);
        public Task ClearCart(int id);
        public Task CheckOut();

    }
}
