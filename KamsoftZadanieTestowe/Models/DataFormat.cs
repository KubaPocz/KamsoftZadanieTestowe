namespace KamsoftZadanieTestowe.Models;
using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DataFormat
    {
        CSV,
        INTERNAL_JSON
    }
