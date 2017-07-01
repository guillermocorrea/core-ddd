using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.Loadtesting.Domain;

namespace WebSuiteDDD.Loadtesting.Repository.EF
{
    public class LoadTestingContext : DbContext
    {
        public LoadTestingContext(DbContextOptions<LoadTestingContext> options) : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Loadtest> Loadtests { get; set; }
        public DbSet<LoadtestType> LoadtestTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }
    }
}
