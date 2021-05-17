using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Doctorsapointment.Models
{
    public class Model : DbContext
    {
        public Model() : base("DBCS")
        {
        }
        public DbSet<doctor> doctors { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}