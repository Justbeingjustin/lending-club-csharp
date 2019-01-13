using System.Collections.Generic;

namespace LendingClub.Models
{
    public class CancelTransfersRequest
    {
        /// <summary>
        /// Transfer transaction Id
        /// </summary>
        public List<int> transferIds { get; set; }
    }
}