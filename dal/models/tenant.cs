using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class tenant
    {
        [Key]
        public int Id { get; set; }
        public int utilityId { get; set; }
        public int flatId { get; set; }
        public string utilityStatus { get; set; }
        public int tenantId { get; set; }

        [ForeignKey("tenantId")]
        public virtual user user { get; set; }
        [ForeignKey("flatId")]
        public virtual flat flat { get; set; }
        [ForeignKey("utilityId")]
        public virtual service service { get; set; }

    }
}
