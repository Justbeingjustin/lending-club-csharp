using Newtonsoft.Json;
using System.Collections.Generic;

namespace LendingClub.Models
{
    public class PortfolioContainer
    {
        [JsonProperty("myPortfolios")]
        public List<Portfolio> Portfolios { get; set; }
    }
}