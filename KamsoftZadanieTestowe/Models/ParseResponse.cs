namespace KamsoftZadanieTestowe.Models
{
    public class ParseResponse
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
        public int Count { get; set; }
        public object? Items { get; set; }
    }
}
