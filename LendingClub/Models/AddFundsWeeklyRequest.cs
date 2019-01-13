using System;

namespace LendingClub.Models
{
    public class AddFundsWeeklyRequest
    {
        public string transferFrequency { get; set; } = "LOAD_WEEKLY";
        public int amount { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}