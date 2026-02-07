using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;

namespace eCommerce.Services
{
    public class CartItemService : BaseCRUDService<CartItemRESPONSE, CartItemSOBJ, Database.CartItem, CartItemREQUST, CartItemREQUST>, ICartItemService
    {
        public CartItemService(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
