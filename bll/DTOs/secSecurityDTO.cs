using dal.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll.DTOs
{
    public class secSecurityDTO
    {
        public int sid { get; set; }

        public string rank { get; set; }


        public string sotiton { get; set; }


        public string shifts { get; set; }

        public int salary { get; set; }


      //  public int user_id { get; set;  }

     //   public virtual user user { get; set; }



        
    }
}
