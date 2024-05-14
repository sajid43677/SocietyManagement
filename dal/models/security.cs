using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class security
    {
        [Key]
        public int sid { get; set; }
        public string rank { get; set; }

        public string sotiton { get; set; }

        public string shifts { get; set; }
        public int salary  { get; set; }

        [ForeignKey("user")]

        public int user_id;
        public virtual user user { get; set; }



        public virtual ICollection<gatepass> gatepasses { get; set; }
        public security()
        {
            gatepasses = new List<gatepass>();
        }


    }
}
