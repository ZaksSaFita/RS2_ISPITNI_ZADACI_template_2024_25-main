using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class ProductDiscountBrojIndeksaService : BaseCRUDService<ProductDiscountBrojIndeksaRESPONSE, ProductDiscountBrojIndeksaSOBJ, Database.ProductDiscountBrojIndeksa, ProductDiscountBrojIndeksaUPSERT, ProductDiscountBrojIndeksaUPSERT>, IProductDiscountBrojIndeksaService
    {
        public ProductDiscountBrojIndeksaService(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }



        protected override IQueryable<ProductDiscountBrojIndeksa> ApplyFilter(IQueryable<ProductDiscountBrojIndeksa> query, ProductDiscountBrojIndeksaSOBJ search)
        {
            query = query.Include(x => x.Product).ThenInclude(x => x.Assets);
            if (!string.IsNullOrEmpty(search.FTS))
            {
                query = query.Where(p => p.Product.Name.Contains(search.FTS));
            }


            return query;
        }


        protected override ProductDiscountBrojIndeksaRESPONSE MapToResponse(ProductDiscountBrojIndeksa entity)
        {
            var prod = _context.Products.FirstOrDefault(x => x.Id == entity.ProductId);

            entity.OldPrice = prod?.Price == 0 ? 0 : prod?.Price;
            if (entity.OldPrice != null || entity.OldPrice != 0)
            {

                entity.NewPrice = entity.OldPrice * (1 - entity.Discount / 100);
            }

            return base.MapToResponse(entity);
        }

    }
}
