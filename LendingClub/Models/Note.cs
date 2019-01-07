using System;

namespace LendingClub.Models
{
    public class Note
    {
        /// <summary>
        /// Loan Id
        /// </summary>
        public int loanId { get; set; }

        /// <summary>
        /// Note Id
        /// </summary>
        public int noteId { get; set; }

        /// <summary>
        /// Order Id
        /// </summary>
        public int orderId { get; set; }

        /// <summary>
        /// Interest rate
        /// </summary>
        public double interestRate { get; set; }

        /// <summary>
        /// Term
        /// </summary>
        public int loanLength { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string loanStatus { get; set; }

        /// <summary>
        /// Grade
        /// </summary>
        public string grade { get; set; }

        /// <summary>
        /// Loan amount
        /// </summary>
        public int loanAmount { get; set; }

        /// <summary>
        /// Invested
        /// </summary>
        public int noteAmount { get; set; }

        /// <summary>
        /// Payments received to Date
        /// </summary>
        public double paymentsReceived { get; set; }

        /// <summary>
        /// Issue date
        /// </summary>
        public DateTime issueDate { get; set; }

        /// <summary>
        /// Order date
        /// </summary>
        public DateTime orderDate { get; set; }

        /// <summary>
        /// Status date
        /// </summary>
        public DateTime loanStatusDate { get; set; }
    }
}