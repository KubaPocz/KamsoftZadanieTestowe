using KamsoftZadanieTestowe.Models;
using System.ComponentModel.DataAnnotations;

namespace KamsoftZadanieTestowe.Services
{
    public interface IParserFactory
    {
        public IParser GetParser(DataFormat type);
    }
}
