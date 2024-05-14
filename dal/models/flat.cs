using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace dal.models
{
    public class flat
    {
        [Key]
        public int Id { get; set; }

        public string flat_number { get; set; }

        public string building_number { get; set; }

        public double rent { get; set; }

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
        public virtual ICollection<tenant> tenants { get; set; }
        public flat()
        {
            tenants = new List<tenant>();
        }
    }
}
