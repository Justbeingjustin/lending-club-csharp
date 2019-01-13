using LendingClub.Models;
using System.Threading.Tasks;

namespace LendingClub.Services
{
    public interface IAccountRepository
    {
        AccountSummary GetAccountSummary();

        Task<AccountSummary> GetAccountSummaryAsync();

        AvailableCash GetAvailableCash();

        Task<AvailableCash> GetAvailableCashAsync();

        NotesContainer GetNotes();

        Task<NotesContainer> GetNotesAsync();

        DetailedNotesContainer GetDetailedNotes();

        Task<DetailedNotesContainer> GetDetailedNotesAsync();

        PortfolioContainer GetPortfolios();

        Task<PortfolioContainer> GetPortfoliosAsync();

        Portfolio CreatePortfolio(CreatePortfolioRequest portfolioRequest);

        Task<Portfolio> CreatePortfolioAsync(CreatePortfolioRequest portfolioRequest);

        AddFundsReceipt AddFundsOnce(AddFundsOnceRequest addFundsOnceRequest);

        Task<AddFundsReceipt> AddFundsOnceAsync(AddFundsOnceRequest addFundsOnceRequest);

        AddFundsReceipt AddFundsBiWeekly(AddFundsBiWeeklyRequest addFundsBiWeeklyRequest);

        Task<AddFundsReceipt> AddFundsBiWeeklyAsync(AddFundsBiWeeklyRequest addFundsBiWeeklyRequest);

        AddFundsReceipt AddFundsNow(AddFundsNowRequest addFundsNowRequest);

        Task<AddFundsReceipt> AddFundsNowAsync(AddFundsNowRequest addFundsNowRequest);

        AddFundsReceipt AddFundsWeekly(AddFundsWeeklyRequest addFundsWeeklyRequest);

        Task<AddFundsReceipt> AddFundsWeeklyAsync(AddFundsWeeklyRequest addFundsWeeklyRequest);

        AddFundsReceipt AddFundsMonthly(AddFundsMonthlyRequest addFundsMonthlyRequest);

        Task<AddFundsReceipt> AddFundsMonthlyAsync(AddFundsMonthlyRequest addFundsMonthlyRequest);

        PendingTransfersContainer GetPendingTransfers();

        Task<PendingTransfersContainer> GetPendingTransfersAsync();

        CancelTransactionReceipt CancelTransfers(CancelTransfersRequest cancelTransfersRequest);

        Task<CancelTransactionReceipt> CancelTransfersAsync(CancelTransfersRequest cancelTransfersRequest);

        OrderReceipt SubmitOrder(OrderRequest order);

        Task<OrderReceipt> SubmitOrderAsync(OrderRequest order);
    }
}