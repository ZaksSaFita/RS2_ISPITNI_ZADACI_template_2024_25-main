using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class CartSERVICE : BaseCRUDService<CartRESPONSE, CartSOBJ, Database.Cart, CartREQUEST, CartREQUEST>, ICartSERVICE
    {
        public CartSERVICE(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
        {
        }


        protected override IQueryable<Cart> ApplyFilter(IQueryable<Cart> query, CartSOBJ search)
        {
            query = query.Include(x => x.User).Include(x => x.CartItems).ThenInclude(x => x.Product).ThenInclude(x => x.Assets);
            if (!string.IsNullOrEmpty(search.Username))
            {
                query = query.Where(x => x.User.Username == search.Username);
            }

            return base.ApplyFilter(query, search);
        }

        public override async Task<CartRESPONSE> CreateAsync(CartREQUEST request)
        {
            var cart = await _context.Carts
                .Include(x => x.User)
                .Include(x => x.CartItems)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Assets)
                .FirstOrDefaultAsync(x => x.User.Username == request.Username);
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.ProductId);

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == request.Username);



            if (cart == null)
            {
                cart = new Cart { UserId = user.Id };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            var item = cart.CartItems.FirstOrDefault(x => x.ProductId == request.ProductId);
            var OldQuantity = item?.Quantity ?? 0;

            if (item == null)
            {
                item = new CartItem { CartId = cart.Id, ProductId = request.ProductId, AddedAt = DateTime.UtcNow, Quantity = 1 };
                cart.CartItems.Add(item);

                await _context.SaveChangesAsync();


                var newEvent = new CartEventBrojIndeksa
                {
                    CartId = cart.Id,
                    UserId = cart.UserId,
                    CartItemId = item.Id,
                    CreatedAt = DateTime.UtcNow,
                    EventType = "Add",
                    OldQuantity = OldQuantity,
                    NewQuantity = item.Quantity,
                    ProductName = product?.Name,
                    ProductPrice = product?.Price,
                    UserFullName = cart.User.FirstName + " " + cart.User.LastName

                };

                _context.CartEvents.Add(newEvent);


            }
            else
            {
                item.Quantity++;
                item.UpdatedAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();


                var newEvent = new CartEventBrojIndeksa
                {
                    CartId = cart.Id,
                    UserId = cart.UserId,
                    CartItemId = item.Id,
                    CreatedAt = DateTime.UtcNow,
                    EventType = "Update",
                    OldQuantity = OldQuantity,
                    NewQuantity = item.Quantity,
                    ProductName = product?.Name,
                    ProductPrice = product?.Price,
                    UserFullName = cart.User.FirstName + " " + cart.User.LastName

                };

                _context.CartEvents.Add(newEvent);
            }


            await _context.SaveChangesAsync();

            return _mapper.Map<CartRESPONSE>(cart);


        }

        public async Task DeleteItem(int id)
        {
            var item = await _context.CartItems.FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
                return;


            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.Id == item.CartId);
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == item.ProductId);

            var newEvent = new CartEventBrojIndeksa
            {
                CartId = item.CartId,
                UserId = item.Cart.UserId,
                CartItemId = item.Id,
                CreatedAt = DateTime.UtcNow,
                EventType = "Delete",
                OldQuantity = item.Quantity,
                NewQuantity = item.Quantity,
                ProductName = product?.Name,
                ProductPrice = product?.Price,
                UserFullName = cart?.User.FirstName + " " + cart?.User.LastName

            };

            _context.CartEvents.Add(newEvent);
            await _context.SaveChangesAsync();



            _context.CartItems.Remove(item);
            await _context.SaveChangesAsync();


        }

        public async Task ClearCart(int cartId)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.Id == cartId);

            var cartItems = await _context.CartItems
                .Where(x => x.CartId == cartId)
                .ToListAsync();


            if (cartItems == null)
                return;

            foreach (var item in cartItems)
            {
                var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == item.ProductId);

                var newEvent = new CartEventBrojIndeksa
                {
                    CartId = cart.Id,
                    UserId = cart.UserId,
                    CartItemId = item.Id,
                    CreatedAt = DateTime.UtcNow,
                    EventType = "Clear",
                    OldQuantity = item.Quantity,
                    NewQuantity = item.Quantity,
                    ProductName = product?.Name,
                    ProductPrice = product?.Price,
                    UserFullName = cart?.User.FirstName + " " + cart?.User.LastName

                };

                _context.CartEvents.Add(newEvent);
                await _context.SaveChangesAsync();

                _context.CartItems.Remove(item);

            }
            await _context.SaveChangesAsync();

        }

        public async Task CheckOut(int cartId)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x => x.Id == cartId);



            var newEvent = new CartEventBrojIndeksa
            {
                CartId = cart.Id,
                UserId = cart.UserId,
                CartItemId = null,
                CreatedAt = DateTime.UtcNow,
                EventType = "CheckOut",
                OldQuantity = 0,
                NewQuantity = null,
                ProductName = "",
                ProductPrice = null,
                UserFullName = cart?.User.FirstName + " " + cart?.User.LastName

            };

            _context.CartEvents.Add(newEvent);

            await _context.SaveChangesAsync();
        }



    }
}
