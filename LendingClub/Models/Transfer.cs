using System;

namespace LendingClub.Models
{
    public class Transfer
    {
        /// <summary>
        /// Transfer transaction Id
        /// </summary>
        public int transferId { get; set; }

        /// <summary>
        /// Transfer Scheduled Date
        /// </summary>
        public DateTime transferDate { get; set; }

        /// <summary>
        /// Transfer amount
        /// </summary>
        public decimal amount { get; set; }

        /// <summary>
        /// Transfer Source Account
        /// </summary>
        public string sourceAccount { get; set; }

        /// <summary>
        /// Status of the Scheduled Transfer
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Frequency of Fund Transfer.
        /// Valid values are: LOAD_NOW, LOAD_ONCE, LOAD_WEEKLY, LOAD_BIWEEKLY, LOAD_ON_DAY_1_AND_16, LOAD_MONTHLY
        /// </summary>
        public string frequency { get; set; }

        /// <summary>
        /// Recurring transfer end date or null is returned in case of one time transfers
        /// </summary>
        public DateTime endDate { get; set; }

        /// <summary>
        /// Type of transfer. Valid Values: ADD_FUNDS or WITHDRAW_FUNDS
        /// </summary>
        public string operation { get; set; }

        /// <summary>
        /// Returns boolean indicating whether this transaction can be cancelled or not.
        /// </summary>
        public string cancellable { get; set; }
    }
}