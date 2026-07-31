using CsvHelper;
using System.Globalization;

namespace KamsoftZadanieTestowe.Services
{
    public class CsvParser : IParser
    {
        public object Parse(string rawText)
        {
            using var reader = new StringReader(rawText);

            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<dynamic>()
                         .Select(record => new Dictionary<string, object>((IDictionary<string, object>)record))
                         .ToList();

            return records;
        }
    }
}
