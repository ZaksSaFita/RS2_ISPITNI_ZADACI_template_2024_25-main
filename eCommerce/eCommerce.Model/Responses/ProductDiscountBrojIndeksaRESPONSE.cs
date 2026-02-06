using System;

namespace eCommerce.Model.Responses
{
    public class ProductDiscountBrojIndeksaRESPONSE
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Discount { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }


        public decimal? OldPrice { get; set; }
        public decimal? NewPrice { get; set; }

        public ProductResponse? Product { get; set; }

    }
}
