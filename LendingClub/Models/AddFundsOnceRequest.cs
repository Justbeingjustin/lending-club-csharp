using System;

namespace LendingClub.Models
{
    public class AddFundsOnceRequest
    {
        public string transferFrequency { get; set; } = "LOAD_ONCE";
        public int amount { get; set; }
        public DateTime startDate { get; set; }
    }
}