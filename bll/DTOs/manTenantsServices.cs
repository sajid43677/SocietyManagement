using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class manTenantsServices
    {
        public int tenantId { get; set; }
        public List<manServiceStatus> services { get; set; }

    }
}
