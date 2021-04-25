using Newtonsoft.Json;

namespace JsonCodeSamples.Models
{
    public class Person
    {

        [JsonProperty(PropertyName = "FirstName")]
        public string firstname { get; set; }

        [JsonProperty(PropertyName = "LastName")]
        public string lastname { get; set; }

        [JsonProperty(PropertyName = "Gender")]
        public Gender gender { get; set; }
    }
}
