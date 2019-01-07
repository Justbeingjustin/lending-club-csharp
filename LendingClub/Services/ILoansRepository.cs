using LendingClub.Models;
using System.Threading.Tasks;

namespace LendingClub.Services
{
    public interface ILoansRepository
    {
        Task<LoansContainer> GetLoansAsync();

        LoansContainer GetLoans();

        Task<LoansContainer> GetLoansAsync(GetLoansRequest getLoansRequest);

        LoansContainer GetLoans(GetLoansRequest getLoansRequest);
    }
}