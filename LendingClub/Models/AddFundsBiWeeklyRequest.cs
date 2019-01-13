using System;

namespace LendingClub.Models
{
    public class AddFundsBiWeeklyRequest
    {
        public string transferFrequency { get; set; } = "LOAD_BIWEEKLY";
        public int amount { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}