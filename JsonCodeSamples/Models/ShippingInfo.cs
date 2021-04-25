using Newtonsoft.Json;

namespace JsonCodeSamples.Models
{
    public class ShippingInfo : Person
    {
        [JsonIgnore]
        public int Id { get; set; }
        public AddressDetails AddressDetails { get; set; }
        public override string ToString() => $"{firstname} {lastname} is {gender}\n{AddressDetails}\n";

    }
}