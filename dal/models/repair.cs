using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class repair
    {
        [Key]
        public int Id { get; set; }
        public int userId { get; set; }
        public string repairDescription { get; set; }
        public string repairStatus { get; set; }
        [ForeignKey("userId")]
        public virtual user user { get; set; }
    }
}
