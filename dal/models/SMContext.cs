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

        public DbSet<flat> flats { get; set; }

        public DbSet<gatepass> gatepasses { get; set; }

        public DbSet<repair> repairs { get; set; }

        public DbSet<security> securitys { get; set; }

        public DbSet<service> services { get; set; }

        public DbSet<tenant> tenants { get; set; }

        public DbSet<verification> verifications { get; set; }

    }
}