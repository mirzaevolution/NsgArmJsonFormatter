using Newtonsoft.Json;

namespace NsgArmJsonFormatter.Models
{
    public partial class SecurityRuleProperties
    {
        [JsonProperty("protocol")]
        public string? Protocol { get; set; }

        [JsonProperty("sourcePortRange", NullValueHandling = NullValueHandling.Ignore)]
        public string? SourcePortRange { get; set; }

        [JsonProperty("destinationPortRange", NullValueHandling = NullValueHandling.Ignore)]
        public string? DestinationPortRange { get; set; }

        [JsonProperty("sourceAddressPrefix", NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceAddressPrefix { get; set; }

        [JsonProperty("sourceApplicationSecurityGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationSecurityGroup> SourceApplicationSecurityGroups { get; set; } = new List<ApplicationSecurityGroup>();

        [JsonProperty("destinationAddressPrefix", NullValueHandling = NullValueHandling.Ignore)]
        public string? DestinationAddressPrefix { get; set; }

        [JsonProperty("destinationApplicationSecurityGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationSecurityGroup> DestinationApplicationSecurityGroups { get; set; } = new List<ApplicationSecurityGroup>();

        [JsonProperty("access")]
        public string? Access { get; set; }

        [JsonProperty("priority")]
        public long? Priority { get; set; }

        [JsonProperty("direction")]
        public string? Direction { get; set; }

        [JsonProperty("sourcePortRanges", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourcePortRanges { get; set; } = new List<string>();

        [JsonProperty("destinationPortRanges", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DestinationPortRanges { get; set; } = new List<string>();

        [JsonProperty("sourceAddressPrefixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourceAddressPrefixes { get; set; } = new List<string>();

        [JsonProperty("destinationAddressPrefixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DestinationAddressPrefixes { get; set; } = new List<string>();

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }
    }
}
