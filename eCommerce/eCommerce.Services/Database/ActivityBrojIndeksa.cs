using System.ComponentModel.DataAnnotations;

namespace eCommerce.Services.Database
{
    public class ActivityBrojIndeksa
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; } = DateTime.UtcNow;
    }
}
