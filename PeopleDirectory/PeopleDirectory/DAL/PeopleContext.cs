using PeopleDirectory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PeopleDirectory.DAL
{
    public class PeopleContext : DbContext
    {
        public PeopleContext()
            : base("name=PeopleContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<PeopleContext>(new CreateDatabaseIfNotExists<PeopleContext>());
        }
        public DbSet<Client> Clients { get; set; }
        //public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}