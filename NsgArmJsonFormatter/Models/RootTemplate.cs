

using Newtonsoft.Json;

namespace NsgArmMarkdownGenerator.Models
{
    public partial class RootTemplate
    {
        [JsonProperty("$schema")]
        public Uri? Schema { get; set; }

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
