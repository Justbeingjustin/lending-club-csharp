using System.Collections.Generic;

namespace LendingClub.Models
{
    public class OrderReceipt
    {
        public int orderInstructId { get; set; }
        public List<OrderConfirmation> orderConfirmations { get; set; }
    }
}