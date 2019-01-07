using System;

namespace LendingClub.Models
{
    public class DetailedNote
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
        /// Accrued Interest
        /// </summary>
        public decimal accruedInterest { get; set; }

        /// <summary>
        /// Principal pending
        /// </summary>
        public decimal principalPending { get; set; }

        /// <summary>
        /// Interest pending
        /// </summary>
        public decimal interestPending { get; set; }

        /// <summary>
        /// Principal received
        /// </summary>
        public decimal principalReceived { get; set; }

        /// <summary>
        /// Interest received
        /// </summary>
        public decimal interestReceived { get; set; }

        /// <summary>
        /// Next payment date
        /// </summary>
        public DateTime nextPaymentDate { get; set; }

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

        /// <summary>
        /// The loan application type. Valid values are "INDIVIDUAL" or "JOINT"
        /// </summary>
        public string applicationType { get; set; }

        /// <summary>
        /// The loan disbursement method. Valid values are "DIRECT_PAY" or "CASH".
        /// </summary>
        public string disbursementMethod { get; set; }
    }
}