using System;

namespace LendingClub.Models
{
    public class AddFundsReceipt
    {
        public int investorId { get; set; }
        public int amount { get; set; }
        public string frequency { get; set; }
        public DateTime startD { get; set; }
        public object endD { get; set; }
        public DateTime estimatedFundsTransferDate { get; set; }
    }
}