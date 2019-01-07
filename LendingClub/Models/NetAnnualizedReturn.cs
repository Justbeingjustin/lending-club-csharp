namespace LendingClub.Models
{
    public class NetAnnualizedReturn
    {
        /// <summary>
        /// Primary Net Annualized Return
        /// </summary>
        public decimal? primaryNAR { get; set; }

        /// <summary>
        /// Primary Adjusted Net Annualized Return based on LendingClub's loss assumptions
        /// </summary>
        public decimal? primaryAdjustedNAR { get; set; }

        /// <summary>
        /// Primary Adjusted Net Annualized Return based on user's loss assumptions
        /// </summary>
        public decimal? primaryUserAdjustedNAR { get; set; }

        /// <summary>
        /// Traded Net Annualized Return
        /// </summary>
        public decimal? tradedNAR { get; set; }

        /// <summary>
        /// Traded Adjusted Net Annualized Return based on LendingClub's loss assumptions
        /// </summary>
        public decimal? tradedAdjustedNAR { get; set; }

        /// <summary>
        /// Traded Adjusted Net Annualized Return based on user's loss assumptions
        /// </summary>
        public decimal? tradedUserAdjustedNAR { get; set; }

        /// <summary>
        /// Combined Net Annualized Return
        /// </summary>
        public decimal? combinedNAR { get; set; }

        /// <summary>
        /// Combined Net Annualized Return based on LendingClub's loss assumptions
        /// </summary>
        public decimal? combinedAdjustedNAR { get; set; }

        /// <summary>
        /// Combined Net Annualized Return based on user's loss assumptions
        /// </summary>
        public decimal? combinedUserAdjustedNAR { get; set; }
    }
}