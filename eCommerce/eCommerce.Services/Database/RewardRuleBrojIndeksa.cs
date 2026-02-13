using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Services.Database
{
    public class RewardRuleBrojIndeksa
    {
        [Key]
        public int Id { get; set; }
        public int ActivityBrojIndeksaId { get; set; }

        [ForeignKey("ActivityBrojIndeksaId")]
        public ActivityBrojIndeksa ActivityBrojIndeksa { get; set; }


        public string? RewardTitle { get; set; }
        public int MaxDaysToComplete { get; set; } = 0;

        public int NumberOfPoints { get; set; } = 0;

    }
}
