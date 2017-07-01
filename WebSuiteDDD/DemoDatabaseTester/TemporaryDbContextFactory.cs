using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WebSuiteDDD.Repository.EF;

namespace DemoDatabaseTester
{
    public class TemporaryDbContextFactory : IDbContextFactory<WebSuiteContext>
    {
        public WebSuiteContext Create(DbContextFactoryOptions options)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("WebSuiteContext"), b => b.MigrationsAssembly("DemoDatabaseTester"));

            var context = new WebSuiteContext(optionsBuilder.Options);

            context.Database.EnsureCreated();
            context.EnsureSeedData();

            return context;
        }
    }
}
