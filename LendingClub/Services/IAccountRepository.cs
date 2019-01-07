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
    }
}