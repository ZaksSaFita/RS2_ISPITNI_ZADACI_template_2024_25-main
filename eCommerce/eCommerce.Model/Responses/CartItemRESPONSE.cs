namespace eCommerce.Model.Responses
{
    public class CartItemRESPONSE
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public ProductResponse? Product { get; set; }
    }
}
