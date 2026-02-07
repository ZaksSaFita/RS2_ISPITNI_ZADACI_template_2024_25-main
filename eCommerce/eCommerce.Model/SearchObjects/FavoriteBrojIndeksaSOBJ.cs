using System;

namespace eCommerce.Model.SearchObjects
{
    public class FavoriteBrojIndeksaSOBJ : BaseSearchObject
    {
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

    }
}
