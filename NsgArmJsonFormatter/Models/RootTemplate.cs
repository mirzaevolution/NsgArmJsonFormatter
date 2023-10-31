

using Newtonsoft.Json;

namespace NsgArmJsonFormatter.Models
{
    public partial class RootTemplate
    {
        [JsonProperty("$schema")]
        public string? Schema { get; set; }

        [JsonProperty("contentVersion")]

        public string? ContentVersion { get; set; }

        [JsonProperty("parameters")]

        public object? Parameters { get; set; }

        [JsonProperty("variables")]
        public object? Variables { get; set; }

        [JsonProperty("resources")]
        public List<Resource> Resources { get; set; } = new List<Resource>();
    }
}
