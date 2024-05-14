using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class announcementCommentDto:announcementDto
    {
        public List<commentDto> comments { get; set; }
        public announcementCommentDto() {
            comments= new List<commentDto>();
        }

    }
}
