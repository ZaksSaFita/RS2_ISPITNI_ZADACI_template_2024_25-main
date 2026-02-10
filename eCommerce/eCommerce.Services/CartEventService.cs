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
            query = query.Include(x => x.User).Include(x => x.Cart).Include(x => x.CartItem).ThenInclude(x => x.Product);

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

        protected override CartEventBrojIndeksaRESPONSE MapToResponse(CartEventBrojIndeksa entity)
        {

            return base.MapToResponse(entity);
        }



    }
}
