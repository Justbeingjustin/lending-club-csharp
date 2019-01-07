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

        public async Task<Portfolio> CreatePortfolioAsync(CreatePortfolioRequest portfolioRequest)
        {
            var client = new RestClient(baseUrl + _investorId + "/portfolios");
            var request = new RestRequest(Method.POST);
            var portfolioRequestWithActorId = (CreatePortfolioRequestWithActorId)portfolioRequest;
            portfolioRequestWithActorId.ActorId = _investorId;
            request.AddHeader(authorization, _apiKey);
            request.AddParameter("application/json", JsonConvert.SerializeObject(portfolioRequestWithActorId), ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<Portfolio>(response.Content);
        }

        public Portfolio CreatePortfolio(CreatePortfolioRequest portfolioRequest)
        {
            var client = new RestClient(baseUrl + _investorId + "/portfolios");
            var request = new RestRequest(Method.POST);
            var portfolioRequestWithActorId = (CreatePortfolioRequestWithActorId)portfolioRequest;
            portfolioRequestWithActorId.ActorId = _investorId;
            request.AddHeader(authorization, _apiKey);
            request.AddParameter("application/json", JsonConvert.SerializeObject(portfolioRequestWithActorId), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<Portfolio>(response.Content);
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

        public DetailedNotesContainer GetDetailedNotes()
        {
            var client = new RestClient(baseUrl + _investorId + "/detailednotes");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<DetailedNotesContainer>(response.Content);
        }

        public async Task<DetailedNotesContainer> GetDetailedNotesAsync()
        {
            var client = new RestClient(baseUrl + _investorId + "/detailednotes");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<DetailedNotesContainer>(response.Content);
        }

        public NotesContainer GetNotes()
        {
            var client = new RestClient(baseUrl + _investorId + "/notes");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<NotesContainer>(response.Content);
        }

        public async Task<NotesContainer> GetNotesAsync()
        {
            var client = new RestClient(baseUrl + _investorId + "/notes");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<NotesContainer>(response.Content);
        }

        public PortfolioContainer GetPortfolios()
        {
            var client = new RestClient(baseUrl + _investorId + "/portfolios");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<PortfolioContainer>(response.Content);
        }

        public async Task<PortfolioContainer> GetPortfoliosAsync()
        {
            var client = new RestClient(baseUrl + _investorId + "/portfolios");
            var request = new RestRequest(Method.GET);
            request.AddHeader(authorization, _apiKey);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<PortfolioContainer>(response.Content);
        }
    }
}