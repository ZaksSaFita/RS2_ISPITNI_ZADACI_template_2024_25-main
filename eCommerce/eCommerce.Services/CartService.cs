using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class CartService : BaseCRUDService<CartRESPONSE, CartSOBJ, Database.Cart, CartREQUEST, CartREQUEST>, ICartService
    {
        public CartService(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        protected override IQueryable<Cart> ApplyFilter(IQueryable<Cart> query, CartSOBJ search)
        {
            query = query.Include(x => x.User).Include(x => x.CartItems).ThenInclude(x => x.Product).ThenInclude(x => x.Assets);
            if (search.UserId != null)
            {
                query = query.Where(x => x.UserId == search.UserId);
            }


            return query;
        }

        public async Task<CartRESPONSE> addToCart(CartItemREQUST request)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.UserId == request.UserId);

            if (cart == null)
            {
                cart = new Cart { UserId = request.UserId };


                _context.Carts.Add(cart);
            }

            var exist = await _context.CartItems.FirstOrDefaultAsync(x => x.ProductId == request.ProductId && x.CartId == cart.Id);

            if (exist != null)
            {
                exist.Quantity++;
                exist.UpdatedAt = DateTime.UtcNow;

                await _context.SaveChangesAsync();
            }
            else
            {
                var item = new CartItem { CartId = cart.Id, ProductId = request.ProductId, Quantity = 1, AddedAt = DateTime.UtcNow };

                cart.CartItems.Add(item);

                await _context.SaveChangesAsync();
            }

            return _mapper.Map<CartRESPONSE>(cart);
        }

        public async Task removeFromCart(int ItemId)
        {
            var item = await _context.CartItems.FirstOrDefaultAsync(x => x.Id == ItemId);
            if (item == null)
            {
                return;
            }
            _context.CartItems.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
