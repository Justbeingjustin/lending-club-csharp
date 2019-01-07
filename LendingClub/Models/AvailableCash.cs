namespace LendingClub.Models
{
    public class AvailableCash
    {
        /// <summary>
        /// The id of the investor account
        /// </summary>
        public int investorId { get; set; }

        /// <summary>
        /// Available cash amount
        /// </summary>
        public double availableCash { get; set; }
    }
}