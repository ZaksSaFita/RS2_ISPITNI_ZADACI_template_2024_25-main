using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class CartEventService : BaseCRUDService<CartEventBrojIndeksaRESPONSE, CartEventBrojIndeksaSOBJ, Database.CartEventBrojIndeksa, CartEventBrojIndeksaREQUEST, CartEventBrojIndeksaREQUEST>, ICartEventService
    {
        public CartEventService(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }


        protected override IQueryable<CartEventBrojIndeksa> ApplyFilter(IQueryable<CartEventBrojIndeksa> query, CartEventBrojIndeksaSOBJ search)
        {
            query = query.Include(x => x.User).Include(x => x.Cart);

            if (!string.IsNullOrEmpty(search.Username))
            {
                query = query.Where(x => x.User.Username == search.Username);
            }
            if (!string.IsNullOrEmpty(search.FTS))
            {
                query = query.Where(x => x.EventType == search.FTS);
            }

            return base.ApplyFilter(query, search);
        }




        //protected override CartEventBrojIndeksaRESPONSE MapToResponse(CartEventBrojIndeksa entity)
        //{
        //    var response = base.MapToResponse(entity);

        //    var cart = _context.Carts.Include(x => x.CartItems).FirstOrDefault(x => x.Id == response.CartId);
        //    var item = _context.CartItems.Include(x => x.Product).FirstOrDefault(x => x.Id == entity.CartItemId);


        //    response.UserFullName = cart?.User.FirstName + " " + cart?.User.LastName;
        //    response.ProductName = item?.Product == null ? "" : item.Product.Name;


        //    return response;
        //}





    }
}
