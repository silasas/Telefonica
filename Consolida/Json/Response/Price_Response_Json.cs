using System.ComponentModel.DataAnnotations;

namespace Consolida.Json.Response
{
    public class Price_Response_Json
    {
        public int Id { get; set; }
        public string? Code { get; set; } 
        public string? ProductCode { get; set; } 
        public decimal? Price { get; set; } 
    }
}
