using System;

namespace eCommerce.Model.Responses
{
    public class CartEventBrojIndeksaRESPONSE
    {
        public int Id { get; set; }
        public CartRESPONSE? Cart { get; set; }

        public string? EventType { get; set; }

        public DateTime CreatedAt { get; set; }


    }
}
