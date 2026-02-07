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

        public async Task<CartRESPONSE> addToCart(int userId, CartItemREQUST request)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.UserId == userId);
            //check if entity is null
            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId,
                    CartItems = new List<CartItem>
            {
                new CartItem
                {
                    ProductId = request.ProductId,
                    Quantity = request.Quantity,
                    AddedAt = DateTime.Now
                }
            }
                };

                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();

                return _mapper.Map<CartRESPONSE>(cart);

            }

            var item = cart.CartItems
        .FirstOrDefault(x => x.ProductId == request.ProductId);

            if (item != null)
            {
                item.Quantity += request.Quantity;
                item.UpdatedAt = DateTime.Now;
            }
            else
            {
                cart.CartItems.Add(new CartItem
                {
                    ProductId = request.ProductId,
                    Quantity = request.Quantity,
                    AddedAt = DateTime.Now
                });
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<CartRESPONSE>(cart);
        }


    }
}
