using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class announcement
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [ForeignKey("user")]
        public int announcmentBy { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual user user { get; set; }

        public virtual ICollection<comment> comments { get; set; }

        public announcement()
        {
            comments = new List<comment>();

        }
    }
}
