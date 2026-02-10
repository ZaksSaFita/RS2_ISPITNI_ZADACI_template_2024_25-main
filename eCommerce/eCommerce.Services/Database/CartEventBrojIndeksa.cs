using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Services.Database
{
    public class CartEventBrojIndeksa
    {
        [Key]
        public int Id { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }


        public int? CartId { get; set; }

        [ForeignKey("CartId")]
        public Cart? Cart { get; set; }


        public int? CartItemId { get; set; }

        [ForeignKey("CartItemId")]
        public CartItem? CartItem { get; set; }



        public string? EventType { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string? Pname { get; set; }
        public decimal? Pprice { get; set; }

        public int OldQuantity { get; set; } = 0;
        public int? NewQuantity { get; set; }
    }
}
