using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Services.Database
{
    public class FavoriteBrojIndeksa
    {
        [Key]
        public int Id { get; set; }

        // Product
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; } = null!;

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } = null!;



        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
/*U okviru templejta projekta, na Web API dijelu, dodati entitet FavoriteBrojIndeksa koji
služi za čuvanje liste omiljenih proizvoda svakog korisnika. Entitet treba sadržavati vezu
na korisnika i proizvod, datum i vrijeme dodavanja proizvoda u listu omiljenih, te druge
atribute koje budete smatrali potrebnim. */