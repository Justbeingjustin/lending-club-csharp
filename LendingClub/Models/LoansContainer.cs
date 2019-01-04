using System;
using System.Collections.Generic;

namespace LendingClub.Models
{
    public class LoansContainer
    {
        /// <summary>
        /// As of date
        /// </summary>
        public DateTime asOfDate { get; set; }

        public List<Loan> loans { get; set; }
    }
}