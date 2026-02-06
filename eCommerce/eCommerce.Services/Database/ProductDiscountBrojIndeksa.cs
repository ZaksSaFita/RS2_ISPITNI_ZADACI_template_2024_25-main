using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Services.Database
{
    public class ProductDiscountBrojIndeksa
    {
        [Key]
        public int Id { get; set; }


        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; } = null!;



        public decimal Discount { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }


        public decimal? OldPrice { get; set; }

        public decimal? NewPrice { get; set; }




    }
}
