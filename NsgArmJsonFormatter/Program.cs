using CommandLine;
using Newtonsoft.Json;
using NsgArmJsonFormatter.Helpers;
using NsgArmJsonFormatter.Models;
using Serilog;

namespace NsgArmJsonFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                        .WriteTo.Console()
                        .CreateLogger();
            Log.Information("--------------------------------------------------");
            Log.Information("NSG ARM Template Formatter");
            Log.Information("Developed by uptec.io (Mirza Ghulam Rasyid)");
            Log.Information("--------------------------------------------------\n");
            string fileLocation = "";
            List<string> parserErrors = new List<string>();
            Parser.Default.ParseArguments<CommandParser>(args)
                .WithParsed<CommandParser>(o =>
                {
                    if (!string.IsNullOrEmpty(o.FileLocation))
                    {
                        fileLocation = o.FileLocation.Trim();
                        if (!File.Exists(fileLocation))
                        {
                            parserErrors.Add($"'{fileLocation}' not found");
                            Log.Error($"'{fileLocation}' not found");
                        }
                    }
                    else
                    {
                        parserErrors.Add("'--file-location' parameter is required!");
                        Log.Error("'--file-location' parameter is required!");
                    }
                });
            if (parserErrors.Count > 0)
            {
                throw new Exception(JsonConvert.SerializeObject(parserErrors));
            }
            else
            {
                new JsonObjectFormatterHelper()
                    .Format(fileLocation);
            }
        }
    }
}