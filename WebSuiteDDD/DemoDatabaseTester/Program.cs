using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using WebSuiteDDD.Repository.EF;
using WebSuiteDDD.Repository.EF.DataModel;

namespace DemoDatabaseTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //IConfigurationRoot configuration = builder.Build();

            //var optionsBuilder = new DbContextOptionsBuilder();

            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("WebSuiteContext"));

            //var context = new WebSuiteContext(optionsBuilder.Options);

            //context.Database.EnsureCreated();
            TemporaryDbContextFactory tmp = new TemporaryDbContextFactory();
            var context = tmp.Create(null);
        }
    }
}