namespace LendingClub.Models
{
    public class AccountSummary
    {   /// <summary>
        /// Investor ID
        /// </summary>
        public int investorId { get; set; }

        /// <summary>
        /// Available cash amount
        /// </summary>
        public decimal availableCash { get; set; }

        /// <summary>
        /// Account total
        /// </summary>
        public decimal accountTotal { get; set; }

        /// <summary>
        /// Accrued interest amount
        /// </summary>
        public decimal accruedInterest { get; set; }

        /// <summary>
        /// In-Funding balance
        /// </summary>
        public int infundingBalance { get; set; }

        /// <summary>
        /// Received interest
        /// </summary>
        public decimal receivedInterest { get; set; }

        /// <summary>
        /// Received principal
        /// </summary>
        public decimal receivedPrincipal { get; set; }

        /// <summary>
        /// Received late fees
        /// </summary>
        public int? receivedLateFees { get; set; }

        /// <summary>
        /// Outstanding principal amount
        /// </summary>
        public decimal outstandingPrincipal { get; set; }

        /// <summary>
        /// Total notes
        /// </summary>
        public int totalNotes { get; set; }

        /// <summary>
        /// Total portfolios
        /// </summary>
        public int totalPortfolios { get; set; }

        /// <summary>
        /// Net Annualized Return (NAR) values object containing different NAR values
        /// </summary>
        public NetAnnualizedReturn netAnnualizedReturn { get; set; }

        /// <summary>
        /// Adjustments to Account Values
        /// </summary>
        public Adjustments adjustments { get; set; }
    }
}