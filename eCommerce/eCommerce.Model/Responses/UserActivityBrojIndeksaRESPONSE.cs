using System;

namespace eCommerce.Model.Responses
{
    public class UserActivityBrojIndeksaRESPONSE
    {
        public int Id { get; set; }

        public UserResponse? User { get; set; }
        public ActivityBrojIndeksaRESPONSE? ActivityBrojIndeksa { get; set; }

        public DateTime AssignedAt { get; set; }
        public string? Status { get; set; }
        public string? Note { get; set; }
        public DateTime CompletedAt { get; set; }

        public string? RewardTitle { get; set; }
        public DateTime RewardedAt { get; set; }
        public int NumberOfPoints { get; set; }
    }
}
