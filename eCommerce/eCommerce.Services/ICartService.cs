using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;

namespace eCommerce.Services
{
    public interface ICartService : ICRUDService<CartRESPONSE, CartSOBJ, CartREQUEST, CartREQUEST>
    {
        Task<CartRESPONSE> addToCart(CartItemREQUST request);
        public Task removeFromCart(int ItemId);

    }
}
