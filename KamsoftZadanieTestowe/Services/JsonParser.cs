using System.Text.Json;

namespace KamsoftZadanieTestowe.Services
{
    public class JsonParser : IParser
    {
        public object Parse(string rawText)
        {
            using var doc = JsonDocument.Parse(rawText);
            var root = doc.RootElement;

            var items = new List<Dictionary<string, object>>();

            if (root.ValueKind == JsonValueKind.Array)
            {
                foreach (var element in root.EnumerateArray())
                {
                    var row = new Dictionary<string, object>();
                    foreach (var property in element.EnumerateObject())
                    {
                        row[property.Name] = property.Value.ToString();
                    }
                    items.Add(row);
                }
            }
            else if (root.ValueKind == JsonValueKind.Object)
            {
                var row = new Dictionary<string, object>();
                foreach (var property in root.EnumerateObject())
                {
                    row[property.Name] = property.Value.ToString();
                }
                items.Add(row);
            }
            return items;
        }
    }
}
