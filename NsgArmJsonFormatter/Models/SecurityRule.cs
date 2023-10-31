using Newtonsoft.Json;

namespace NsgArmJsonFormatter.Models
{
    public partial class SecurityRule
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("properties")]
        public SecurityRuleProperties Properties { get; set; } = new SecurityRuleProperties();
    }
}
