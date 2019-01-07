using Newtonsoft.Json;

namespace LendingClub.Models
{
    public class CreatePortfolioRequestWithActorId
    {
        [JsonProperty("actorId")]
        public string ActorId { get; set; }

        [JsonProperty("portfolioName")]
        public string PortfolioName { get; set; }

        [JsonProperty("portfolioDescription")]
        public string PortfolioDescription { get; set; }
    }
}