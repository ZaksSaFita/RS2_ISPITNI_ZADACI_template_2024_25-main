using System;

namespace eCommerce.Model.Responses
{
    public class CartEventBrojIndeksaRESPONSE
    {
        public int Id { get; set; }
        public string? UserFullName { get; set; }
        public int? CartId { get; set; }
        public int? CartItemId { get; set; }
        public string? EventType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? OldQuantity { get; set; } = 0;
        public int? NewQuantity { get; set; }

    }
}
