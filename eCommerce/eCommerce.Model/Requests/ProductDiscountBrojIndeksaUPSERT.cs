using System;

namespace eCommerce.Model.Requests
{
    public class ProductDiscountBrojIndeksaUPSERT
    {
        public int ProductId { get; set; }
        public decimal Discount { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
