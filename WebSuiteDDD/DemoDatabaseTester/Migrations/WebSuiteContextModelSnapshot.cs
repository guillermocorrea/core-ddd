using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebSuiteDDD.Repository.EF;

namespace DemoDatabaseTester.Migrations
{
    [DbContext(typeof(WebSuiteContext))]
    partial class WebSuiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebSuiteDDD.Repository.EF.DataModel.Agent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("WebSuiteDDD.Repository.EF.DataModel.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("MainContact");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebSuiteDDD.Repository.EF.DataModel.Engineer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Title");

                    b.Property<int>("YearJoinedCompany");

                    b.HasKey("Id");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("WebSuiteDDD.Repository.EF.DataModel.Loadtest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AgentId");

                    b.Property<Guid>("CustomerId");

                    b.Property<int>("DurationSec");

                    b.Property<Guid?>("EngineerId");

                    b.Property<Guid>("LoadtestTypeId");

                    b.Property<Guid>("ProjectId");

                    b.Property<Guid>("ScenarioId");

                    b.Property<DateTime>("StartDateUtc");

                    b.Property<int>("UserCount");

                    b.HasKey("Id");

                    b.ToTable("Loadtests");
                });

            modelBuilder.Entity("WebSuiteDDD.Repository.EF.DataModel.LoadtestType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LongDescription");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.ToTable("LoadtestTypes");
                });

            modelBuilder.Entity("WebSuiteDDD.Repository.EF.DataModel.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateInsertedUtc");

                    b.Property<string>("LongDescription");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebSuiteDDD.Repository.EF.DataModel.Scenario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UriOne");

                    b.Property<string>("UriThree");

                    b.Property<string>("UriTwo");

                    b.HasKey("Id");

                    b.ToTable("Scenarios");
                });
        }
    }
}
