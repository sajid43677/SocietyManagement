using dal.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.Models
{
    internal class SMContext : DbContext
    {
        public DbSet<user> users { get; set; }

    }
}
