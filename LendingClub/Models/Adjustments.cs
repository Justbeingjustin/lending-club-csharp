namespace LendingClub.Models
{
    public class Adjustments
    {    /// <summary>
         /// Adjustments to Account Values for past due notes based on LendingClub's loss assumptions
         /// </summary>
        public decimal adjustmentForPastDueNotes { get; set; }

        /// <summary>
        /// Adjustments to Account Values for past due notes based on user's loss assumptions
        /// </summary>
        public decimal? userAdjustmentForPastDueNotes { get; set; }
    }
}