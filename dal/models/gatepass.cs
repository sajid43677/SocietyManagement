using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class gatepass
    {
        [Key]
        public int pid { get; set; }
        public string building_number { get; set; }

        public DateTime date { get; set; }
        public string status { get; set; }



  

        public int sec_id { get; set; }
        [ForeignKey("sec_id")]
        public virtual security security { get; set; }

      

        public  int flat_id { get; set; }
        [ForeignKey("flat_id")]
        public virtual flat flat { get; set; }


    }
}
