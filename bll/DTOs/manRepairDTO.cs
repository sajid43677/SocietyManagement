using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class manRepairDTO
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string repairDescription { get; set; }
        public string repairStatus { get; set; }
       
    }
}
