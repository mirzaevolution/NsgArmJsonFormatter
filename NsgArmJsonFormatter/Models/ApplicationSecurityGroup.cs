using Newtonsoft.Json;

namespace NsgArmJsonFormatter.Models
{
    public class ApplicationSecurityGroup
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
