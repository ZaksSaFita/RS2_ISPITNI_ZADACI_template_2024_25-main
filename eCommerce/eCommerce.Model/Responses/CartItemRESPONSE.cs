using System;

namespace eCommerce.Model.Responses
{
    public class CartItemRESPONSE
    {
        public int Id { get; set; }


        public int Quantity { get; set; }

        public DateTime AddedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public int CartId { get; set; }
        // public CartRESPONSE? Cart { get; set; }


        public int ProductId { get; set; }

        public ProductResponse? Product { get; set; }
    }
}
