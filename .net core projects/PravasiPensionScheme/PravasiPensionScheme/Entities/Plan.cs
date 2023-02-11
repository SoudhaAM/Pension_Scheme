using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PravasiPensionScheme.Entities
{
    [Table("tbl_Plan")]
    public class Plan
    {
        #region Properties
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
        [Required]
        
        public byte[] Image { get; set; }
        [Required]
        public string Duration { get; set; } = null!;

        [Required]
        public double Amount { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }

        #endregion
    }
}
