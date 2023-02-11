using System.Text.Json.Serialization;

namespace PravasiPensionScheme.DTOs
{
    public class ContactDto
    {
        [JsonIgnore]
        public Guid id { get; set; }
        public string Email { get; set; }
        public long phone { get; set; }
        public string? Address { get; set; }
        public string Discription { get; set; }
    }
}
