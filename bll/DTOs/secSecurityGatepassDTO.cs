using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class secSecurityGatepassDTO : secSecurityDTO
    {
        public List<secGatePassDTO> gatepasses { get; set; }

        public secSecurityGatepassDTO() 
        {
            gatepasses = new List<secGatePassDTO>();
        }
    }
}
