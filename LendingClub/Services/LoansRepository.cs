using LendingClub.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace LendingClub.Services
{
    public class LoansRepository : ILoansRepository
    {
        private readonly string _apiKey;
        private string baseUrl = @"https://api.lendingclub.com/api/investor/v1/loans/listing";
        private string authorization = "authorization";

        public LoansRepository(string apiKey)
        {
            _apiKey = apiKey;
        }

        public LoansContainer GetLoans()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<LoansContainer>(response.Content);
        }

        public async Task<LoansContainer> GetLoansAsync()
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<LoansContainer>(response.Content);
        }
    }
}