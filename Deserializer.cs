using System.IO;
using System.Text.Json;

namespace ConsoleApp1
{
    public class Deserializer
    {
        public static IssuesData IssuesDataDeserialize(string jsonDocument)
        {
            var options = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
            var jsonString = File.ReadAllText(jsonDocument);
            return JsonSerializer.Deserialize<IssuesData>(jsonString, options);
        }
    }
}