using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class verification
    {
        [Key]
        public int vid { get; set; }
        public string vehical_number { get; set; }

        public string vehical_type { get; set; }

        public string owner_name { get; set; }

        public string owner_phone { get; set; }
        public int penalty { get; set; }

        public string status { get; set; }


    }
}