namespace JsonCodeSamples.Models
{
    /// <summary>
    /// For <see cref="Person"/>
    /// </summary>
    public class AddressDetails
    {
        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// For debugging
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Street}\n{City}\n{State}\n{PostalCode}";

    }
}