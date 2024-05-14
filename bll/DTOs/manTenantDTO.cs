using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class manTenantDTO
    {
        public int Id { get; set; }
        public int utilityId { get; set; }
        public int flatId { get; set; }
        public string utilityStatus { get; set; }
        public int tenantId { get; set; }
    }
}
