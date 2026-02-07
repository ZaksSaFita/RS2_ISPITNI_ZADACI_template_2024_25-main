using System;

namespace eCommerce.Model.Responses
{
    public class FavoriteBrojIndeksaRESPONSE
    {
        public int Id { get; set; }

        // Product
        public int ProductId { get; set; }

        public ProductResponse? Product { get; set; } = null!;

        public int UserId { get; set; }

        public UserResponse? User { get; set; } = null!;



        public DateTime CreatedAt { get; set; }
    }
}
