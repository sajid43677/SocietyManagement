using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.models
{
    public class service
    {
        [Key]
        public int Id { get; set; }
        public string utilityName { get; set; }
        public double utilityCharge { get; set; }

        public virtual ICollection<tenant> tenants { get; set; }
        public service()
        {
            tenants = new List<tenant>();
        }
    }
}
