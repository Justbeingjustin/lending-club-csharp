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
    }
}