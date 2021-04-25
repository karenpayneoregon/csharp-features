using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonCodeSamples.Models
{
    public class ShippingInfo : Person
    {
        [JsonIgnore]
        public int Id { get; set; }
        public AddressDetails AddressDetails { get; set; }
        public List<SomethingNested> SomethingNested { get; set; }

        public ShippingInfo()
        {
            SomethingNested = new List<SomethingNested>();
        }
        public override string ToString() => $"{firstname} {lastname} is {gender}\n{AddressDetails}\n";

    }

    public class SomethingNested
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}