using LendingClub.Models;
using System.Collections.Generic;

namespace LendingClub.Models
{
    public class CancelTransactionReceipt
    {
        public int investorId { get; set; }
        public List<CancellationResult> cancellationResults { get; set; }
    }
}