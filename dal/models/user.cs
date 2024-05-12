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

        public user()
        {
            flats = new List<flat>();
        }
    }
}
