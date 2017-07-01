using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.Repository.EF.DataModel;

namespace WebSuiteDDD.Repository.EF
{
    public class WebSuiteContext : DbContext
    {
        public WebSuiteContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Loadtest> Loadtests { get; set; }
        public DbSet<LoadtestType> LoadtestTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Project>().Property(p => p.Description).
            //builder.Entity<Project>().Property(p => p.Description.ShortDescription).HasColumnName("");
        }
    }
}
