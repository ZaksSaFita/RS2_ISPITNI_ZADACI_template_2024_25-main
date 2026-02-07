using System.Collections.Generic;

namespace eCommerce.Model.Responses
{
    public class CartRESPONSE
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public ICollection<CartItemRESPONSE> CartItems { get; set; } = new List<CartItemRESPONSE>();
    }
}
