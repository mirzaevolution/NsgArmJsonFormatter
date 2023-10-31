using Newtonsoft.Json;
using NsgArmJsonFormatter.Models;
using Serilog;

namespace NsgArmJsonFormatter.Helpers
{
    public class JsonObjectFormatterHelper
    {
        public void Format(string fileLocation)
        {
            try
            {

                string jsonInput = File.ReadAllText(fileLocation)?.Trim() ?? "";

                RootTemplate? rootTemplate = JsonConvert.DeserializeObject<RootTemplate>
                    (jsonInput, new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    }) ?? new RootTemplate();
                if (rootTemplate != null)
                {
                    if (rootTemplate != null && rootTemplate.Resources != null && rootTemplate.Resources.Count > 0)
                    {
                        rootTemplate.Resources = new List<Resource>
                        {
                            rootTemplate.Resources[0]
                        };
                        string jsonOutput = JsonConvert.SerializeObject(rootTemplate, Formatting.Indented);
                        File.WriteAllText(fileLocation, jsonOutput);
                        Log.Information($"Formatted json arm template has been saved to '{fileLocation}'");
                    }
                    else
                    {
                        Log.Error("Cannot proceed. Resources obj is null");
                    }
                }
                else
                {
                    Log.Error("Error while deserializing to C# obj. Convertion is null.");
                }

            }
            catch (Exception e)
            {
                Log.Error($"Error: {e.ToString()}");
            }
        }
    }
}
