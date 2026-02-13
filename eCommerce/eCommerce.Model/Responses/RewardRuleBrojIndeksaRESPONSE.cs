namespace eCommerce.Model.Responses
{
    public class RewardRuleBrojIndeksaRESPONSE
    {
        public int Id { get; set; }

        public ActivityBrojIndeksaRESPONSE? ActivityBrojIndeksa { get; set; }

        public string? RewardTitle { get; set; }
        public int MaxDaysToComplete { get; set; }
        public int NumberOfPoints { get; set; }
    }
}
