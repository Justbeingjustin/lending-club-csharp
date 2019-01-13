using System.Collections.Generic;

namespace LendingClub.Models
{
    public class OrderRequestWithActorId
    {
        public int aid { get; set; }
        public List<Order> orders { get; set; }
    }
}