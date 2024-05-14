using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class comment
    {
        public int Id { get; set; }
        [Required]
        public string commentText { get; set; }
        public DateTime time { get; set; }
        [ForeignKey("user")]
        public int commentedBy { get; set; }
        [ForeignKey("announcement")]
        public int announcementId { get; set; }

        public virtual announcement announcement { get; set; }

        public virtual user user { get; set; }




    }
}
