using CommandLine;

namespace NsgArmJsonFormatter.Models
{
    public class CommandParser
    {
        [Option("file-location", HelpText = "File location of json arm template file", Required = true)]
        public string? FileLocation { get; set; }
    }
}
