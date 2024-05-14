using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class commentDto
    {
        public int Id { get; set; }
        [Required]
        public string commentText { get; set; }
        [Required]
        public DateTime time { get; set; }
        [Required]
        public int commentedBy { get; set; }
        [Required]
        public int announcementId { get; set; }

    }
}
