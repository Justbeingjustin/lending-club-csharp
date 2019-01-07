using LendingClub.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace LendingClub.Services
{
    public class AccountRepository : IAccountRepository
    {
        private readonly string _apiKey;
        private readonly string _investorId;
        private string baseUrl = @"https://api.lendingclub.com/api/investor/v1/accounts/";
        private string authorization = "authorization";

        public AccountRepository(string apiKey, string investorId)
        {
            _apiKey = apiKey;
            _investorId = investorId;
        }

        public AccountSummary GetAccountSummary()
        {
            var client = new RestClient(baseUrl + _investorId + "/summary");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<AccountSummary>(response.Content);
        }

        public async Task<AccountSummary> GetAccountSummaryAsync()
        {
            var client = new RestClient(baseUrl + _investorId + "/summary");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<AccountSummary>(response.Content);
        }

        public AvailableCash GetAvailableCash()
        {
            var client = new RestClient(baseUrl + _investorId + "/availablecash");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<AvailableCash>(response.Content);
        }

        public async Task<AvailableCash> GetAvailableCashAsync()
        {
            var client = new RestClient(baseUrl + _investorId + "/availablecash");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<AvailableCash>(response.Content);
        }
    }
}