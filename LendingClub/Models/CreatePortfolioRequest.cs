namespace LendingClub.Models
{
    public class CreatePortfolioRequest
    {
        public string PortfolioName { get; set; }

        public string PortfolioDescription { get; set; }

        public static explicit operator CreatePortfolioRequestWithActorId(CreatePortfolioRequest c)
        {
            return new CreatePortfolioRequestWithActorId() { PortfolioDescription = c.PortfolioDescription, PortfolioName = c.PortfolioName };
        }
    }
}