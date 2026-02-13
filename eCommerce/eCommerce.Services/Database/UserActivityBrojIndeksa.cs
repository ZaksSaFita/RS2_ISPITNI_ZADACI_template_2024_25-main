using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Services.Database
{
    public class UserActivityBrojIndeksa
    {
        [Key]
        public int Id { get; set; }


        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        public int ActivityBrojIndeksaId { get; set; }

        [ForeignKey("ActivityBrojIndeksaId")]
        public ActivityBrojIndeksa? ActivityBrojIndeksa { get; set; }

        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
        public string? Status { get; set; }
        public string? Note { get; set; }
        public DateTime? CompletedAt { get; set; }

        public string? RewardTitle { get; set; }
        public DateTime? RewardedAt { get; set; }
        public int NumberOfPoints { get; set; } = 0;

    }
}
