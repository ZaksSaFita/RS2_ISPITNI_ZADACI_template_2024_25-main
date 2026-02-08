namespace eCommerce.Model.Requests
{
    public class AddToCartRequest
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
