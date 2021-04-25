namespace JsonCodeSamples.Models
{
    public class AddressDetails
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public override string ToString() => $"{Street}\n{City}\n{State}\n{PostalCode}";

    }
}