using System.Collections.Generic;

namespace LendingClub.Models
{
    public class OrderConfirmation
    {
        public int loanId { get; set; }
        public double requestedAmount { get; set; }
        public double investedAmount { get; set; }
        public List<string> executionStatus { get; set; }
    }
}