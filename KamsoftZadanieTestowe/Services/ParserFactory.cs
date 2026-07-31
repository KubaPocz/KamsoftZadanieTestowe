using System.ComponentModel.DataAnnotations;
using KamsoftZadanieTestowe.Models;

namespace KamsoftZadanieTestowe.Services
{
    public class ParserFactory : IParserFactory
    {
        public IParser GetParser(DataFormat type)
        {
            switch (type)
            {
                case DataFormat.CSV:
                    return new CsvParser();
                case DataFormat.INTERNAL_JSON:
                    return new JsonParser();
                default:
                    throw new ArgumentException("Invalid type of data");
            }
        }
    }
}
