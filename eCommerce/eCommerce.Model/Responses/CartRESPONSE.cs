using System.Collections.Generic;

namespace eCommerce.Model.Responses
{
    public class CartRESPONSE
    {
        public int Id { get; set; }

        public UserResponse? User { get; set; } = null!;

        // Navigation property for cart items
        public ICollection<CartItemRESPONSE> CartItems { get; set; } = new List<CartItemRESPONSE>();
    }
}
