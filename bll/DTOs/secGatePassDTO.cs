using dal.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class secGatePassDTO
    {
        public int pid { get; set; }
        public string building_number { get; set; }

        public DateTime date { get; set; }
        public string status { get; set; }

        public int sec_id { get; set; }

        public int flat_id { get; set; }

    }
}
