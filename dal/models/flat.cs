using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dal.models
{
    public class flat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string flat_number { get; set; }

        [Required]
        public string building_number { get; set; }

        [Required]
        public double rent { get; set; }

        [Required]
        public string status { get; set; }

        public int? owner_id { get; set; }
        public int? manager_id { get; set; }
        public int? tenant_id { get; set; }

        [ForeignKey("owner_id")]
        [InverseProperty("flats")]
        public virtual user owner { get; set; }

        [ForeignKey("manager_id")]
        public virtual user manager { get; set; }

        [ForeignKey("tenant_id")]
        public virtual user tenant { get; set; }
    }
}
