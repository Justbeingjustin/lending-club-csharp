namespace LendingClub.Models
{
    public class AddFundsNowRequest
    {
        public string transferFrequency { get; set; } = "LOAD_NOW";
        public int amount { get; set; }
    }
}