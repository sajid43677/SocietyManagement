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
        public DbSet<announcement> announcements { get; set; }
        public DbSet<comment> comments { get; set; }

        public DbSet<report> reports { get; set; }

        public DbSet<rule> rules { get; set; }


    }
}
