using System;

namespace LendingClub.Models
{
    public class AddFundsMonthlyRequest
    {
        public string transferFrequency { get; set; } = "LOAD_MONTHLY";
        public int amount { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}