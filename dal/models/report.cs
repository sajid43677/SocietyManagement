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
        [ForeignKey("user")]
        public int reportedBy { get; set; }
        [ForeignKey("user")]
        public int reportedTo { get; set; }

        public virtual user user { get; set; }

    }
}
