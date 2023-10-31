using CommandLine;

namespace NsgArmMarkdownGenerator.Models
{
    public class CommandParser
    {
        [Option("input-string", HelpText = "Input arm json template as string", Required = true)]
        public string? InputString { get; set; }

        [Option("output-file", HelpText = "Output file location", Required = true)]
        public string? OutputFile { get; set; }
    }
}
