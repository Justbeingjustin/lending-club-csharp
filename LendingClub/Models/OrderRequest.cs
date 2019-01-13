using System.Collections.Generic;

namespace LendingClub.Models
{
    public class OrderRequest
    {
        public List<Order> orders { get; set; }

        public static explicit operator OrderRequestWithActorId(OrderRequest c)
        {
            return new OrderRequestWithActorId() { orders = c.orders };
        }
    }
}