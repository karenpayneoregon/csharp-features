using Newtonsoft.Json;

namespace JsonCodeSamples.Models
{
    /// <summary>
    /// Sample class 
    /// </summary>
    public class Person
    {
        /// <summary>
        /// First name
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string firstname { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty(PropertyName = "LastName")]
        public string lastname { get; set; }
        /// <summary>
        /// Gender
        /// </summary>
        [JsonProperty(PropertyName = "Gender")]
        public Gender gender { get; set; }
    }
}
