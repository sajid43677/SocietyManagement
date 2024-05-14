using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class report
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        
        public int reportedBy { get; set; }
        public int reportedTo { get; set; }
        [ForeignKey("reportedBy")]
        public virtual user user { get; set; }
        [ForeignKey("reportedTo")]
        public virtual user userto { get; set; }

    }
}
