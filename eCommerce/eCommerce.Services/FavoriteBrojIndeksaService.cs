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


        public async Task AddToCart(int userId, int productId)
        {
            var cart = await _context.Carts.Include(x => x.CartItems).FirstOrDefaultAsync(x => x.UserId == userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId, CartItems = new List<CartItem>() };
                _context.Add(cart);
                await _context.SaveChangesAsync();
            }

            var existingItems = await _context.CartItems.Include(x => x.Cart).Include(x => x.Product).FirstOrDefaultAsync(X => X.CartId == cart.Id && X.ProductId == productId);

            if (existingItems != null)
            {
                existingItems.Quantity++;
                existingItems.UpdatedAt = DateTime.UtcNow;



            }
            else
            {
                cart.CartItems.Add(new CartItem
                {
                    CartId = cart.Id,
                    ProductId = productId,
                    AddedAt = DateTime.UtcNow,
                    Quantity = 1
                });
            }

            await _context.SaveChangesAsync();


        }



    }
}
