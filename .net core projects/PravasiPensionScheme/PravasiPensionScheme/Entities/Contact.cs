using System.ComponentModel.DataAnnotations.Schema;

namespace PravasiPensionScheme.Entities
{
    [Table("tbl_Contact")]
    public class Contact

    {
        #region Properties
        public Guid id { get; set; }
        public string Email { get; set; }
        public long phone { get; set; }
        public string Address { get; set; }
        public string Discription { get; set; }
        #endregion
    }
}
