using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dal.models
{
    public class user
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string role { get; set; }

        [Required]
        public string nid { get; set; }

        public virtual ICollection<flat> flats { get; set; }
        public virtual ICollection<tenant> tenants { get; set; }
        public virtual ICollection<repair> repairs { get; set; }

        public virtual ICollection<announcement> announcements { get; set; }




        public user()
        {
            flats = new List<flat>();
            tenants = new List<tenant>();
            repairs = new List<repair>();
            announcements = new List<announcement>();
        }
    }
}
