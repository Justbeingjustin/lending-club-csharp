namespace LendingClub.Models
{
    public class Order
    {/// <summary>
     /// Unique LC assigned id for the loan. This is the same as the id loan attribute returned in the loanListing result of the LoanBrowseLoans operation.
     /// </summary>
        public int loanId { get; set; }

        /// <summary>
        /// Amount to be invested in this loan
        /// </summary>
        public double requestedAmount { get; set; }

        /// <summary>
        /// Unique LC assigned id for the portfolio which this note should be assigned if the order is submitted successfully.
        /// </summary>
        public int portfolioId { get; set; }
    }
}