using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class FavoriteBrojIndeksaService : BaseCRUDService<FavoriteBrojIndeksaRESPONSE, FavoriteBrojIndeksaSOBJ, Database.FavoriteBrojIndeksa, FavoriteBrojIndeksaREQUEST, FavoriteBrojIndeksaREQUEST>, IFavoriteBrojIndeksaService
    {
        public FavoriteBrojIndeksaService(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        protected override IQueryable<FavoriteBrojIndeksa> ApplyFilter(IQueryable<FavoriteBrojIndeksa> query, FavoriteBrojIndeksaSOBJ search)
        {
            query = query.Include(x => x.User).Include(x => x.Product).ThenInclude(x => x.Assets);
            if (search.ProductId != null)
            {
                query = query.Where(x => x.ProductId == search.ProductId);
            }
            if (search.UserId != null)
            {
                query = query.Where(x => x.UserId == search.UserId);
            }
            if (search.From != null)
            {
                query = query.Where(x => x.CreatedAt >= search.From);
            }
            if (search.To != null)
            {
                query = query.Where(x => x.CreatedAt <= search.To);
            }

            return base.ApplyFilter(query, search);

        }

    }
}
