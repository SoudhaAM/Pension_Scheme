using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PravasiPensionScheme.DTOs
{
    public class PlansDto
    {
        [Key]
        [JsonIgnore]
        public Guid? Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public IFormFile ImageFile { get; set; }
        public byte[]? ImageArray { get; set; }

        [Required]
        public string Duration { get; set; } = null!;

        [Required]
        public double Amount { get; set; }

      
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
