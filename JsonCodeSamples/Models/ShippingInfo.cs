using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonCodeSamples.Models
{
    /// <summary>
    /// Example cass
    /// </summary>
    public class ShippingInfo : Person
    {
        /// <summary>
        /// Primary key
        /// </summary>
        [JsonIgnore]
        public int Id { get; set; }
        /// <summary>
        /// Address details
        /// </summary>
        public AddressDetails AddressDetails { get; set; }
        /// <summary>
        /// For demoing nested properties
        /// </summary>
        public List<SomethingNested> SomethingNested { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ShippingInfo()
        {
            SomethingNested = new List<SomethingNested>();
        }
        /// <summary>
        /// For debugging
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{firstname} {lastname} is {gender}\n{AddressDetails}\n";

    }

    /// <summary>
    /// Sample class for <see cref="Person"/>
    /// </summary>
    public class SomethingNested
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Dummy value
        /// </summary>
        public string Value { get; set; }
    }
}