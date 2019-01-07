namespace LendingClub.Models
{
    public class GetLoansRequest
    {
        /// <summary>
        ///  A non-required integer parameter that will filter the contents of the result based on the criteria of the filter.
        ///  The investor's filter identifiers can be retrieved from the filters subresource.
        /// </summary>
        public int? FilterId { get; set; }

        /// <summary>
        /// A non-required Boolean parameter that defines the contents of the result.
        /// </summary>
        public bool ShowAll { get; set; } = true;
    }
}