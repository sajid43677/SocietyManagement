using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class manFlatDTO
    {
        public int Id { get; set; }

        public string flat_number { get; set; }

        public string building_number { get; set; }

        public double rent { get; set; }

        public string status { get; set; }

        public int? owner_id { get; set; }
        public int? manager_id { get; set; }
        public int? tenant_id { get; set; }
    }
}
