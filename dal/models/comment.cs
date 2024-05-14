using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dal.models
{
    public class comment
    {
        public int Id { get; set; }

        [Required]
        public string commentText { get; set; }

        public DateTime time { get; set; }

        public int commentedBy { get; set; }

        public int announcementId { get; set; }

        [ForeignKey("commentedBy")]
        
        public virtual user User { get; set; }

        [ForeignKey("announcementId")]
        public virtual announcement Announcement { get; set; }
    }
}
