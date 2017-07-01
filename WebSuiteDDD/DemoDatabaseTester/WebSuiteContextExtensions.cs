using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.Repository.EF;
using WebSuiteDDD.Repository.EF.DataModel;

namespace DemoDatabaseTester
{
    public static class WebSuiteContextExtensions
    {
        public static void EnsureSeedData(this WebSuiteContext context)
        {
            context.RemoveRange(context.Agents);
            context.SaveChanges();

            List<Agent> agents = new List<Agent>();
            Agent amazon = new Agent();
            amazon.Id = Guid.NewGuid();
            amazon.City = "Seattle";
            amazon.Country = "USA";
            amazon.Latitude = 123.345;
            amazon.Longitude = 135.543;
            
            Agent rackspace = new Agent();
            rackspace.Id = Guid.NewGuid();
            rackspace.City = "Frankfurt";
            rackspace.Country = "Germany";
            rackspace.Latitude = -123.654;
            rackspace.Longitude = 121.321;

            Agent azure = new Agent();
            azure.Id = Guid.NewGuid();
            azure.City = "Tokyo";
            azure.Country = "Japan";
            azure.Latitude = 23.45;
            azure.Longitude = 12.343;
            
            agents.Add(amazon);
            agents.Add(rackspace);
            agents.Add(azure);
            context.Agents.AddRange(agents);

            context.RemoveRange(context.Customers);
            context.SaveChanges();

            List<Customer> customers = new List<Customer>();
            Customer niceCustomer = new Customer();
            niceCustomer.Id = Guid.NewGuid();
            niceCustomer.Address = "New York";
            niceCustomer.MainContact = "Elvis Presley";
            niceCustomer.Name = "Nice customer";

            Customer greatCustomer = new Customer();
            greatCustomer.Id = Guid.NewGuid();
            greatCustomer.Address = "London";
            greatCustomer.MainContact = "Phil Collins";
            greatCustomer.Name = "Great customer";

            Customer okCustomer = new Customer();
            okCustomer.Id = Guid.NewGuid();
            okCustomer.Address = "Berlin";
            okCustomer.MainContact = "Freddie Mercury";
            okCustomer.Name = "OK Customer";

            customers.Add(niceCustomer);
            customers.Add(greatCustomer);
            customers.Add(okCustomer);
            context.Customers.AddRange(customers);

            context.RemoveRange(context.Engineers);
            context.SaveChanges();

            List<Engineer> engineers = new List<Engineer>();
            Engineer john = new Engineer();
            john.Id = Guid.NewGuid();
            john.Name = "John";
            john.Title = "Load test engineer";
            john.YearJoinedCompany = 2013;

            Engineer mary = new Engineer();
            mary.Id = Guid.NewGuid();
            mary.Name = "Mary";
            mary.Title = "Sr. load test engineer";
            mary.YearJoinedCompany = 2012;

            Engineer fred = new Engineer();
            fred.Id = Guid.NewGuid();
            fred.Name = "Fred";
            fred.Title = "Jr. load test engineer";
            fred.YearJoinedCompany = 2014;

            engineers.Add(john);
            engineers.Add(mary);
            engineers.Add(fred);
            context.Engineers.AddRange(engineers);

            context.RemoveRange(context.LoadtestTypes);
            context.SaveChanges();

            List<LoadtestType> testTypes = new List<LoadtestType>();
            LoadtestType stressTest = new LoadtestType();
            stressTest.Id = Guid.NewGuid();
            stressTest.ShortDescription = "Stress test";
            stressTest.LongDescription = "To determine or validate an application’s behavior when it is pushed beyond normal or peak load conditions.";

            LoadtestType capacityTest = new LoadtestType();
            capacityTest.Id = Guid.NewGuid();
            capacityTest.ShortDescription = "Capacity test";
            capacityTest.LongDescription = "To determine how many users and/or transactions a given system will support and still meet performance goals.";

            testTypes.Add(stressTest);
            testTypes.Add(capacityTest);
            context.LoadtestTypes.AddRange(testTypes);

            context.RemoveRange(context.Projects);
            context.SaveChanges();

            List<Project> projects = new List<Project>();
            Project firstProject = new Project();
            firstProject.Id = Guid.NewGuid();
            firstProject.DateInsertedUtc = DateTime.UtcNow;
            firstProject.ShortDescription = "First project";
            firstProject.LongDescription = "Long description of first project";

            Project secondProject = new Project();
            secondProject.Id = Guid.NewGuid();
            secondProject.DateInsertedUtc = DateTime.UtcNow.AddDays(-5);
            secondProject.ShortDescription = "Second project";
            secondProject.LongDescription = "Long description of second project";

            Project thirdProject = new Project();
            thirdProject.Id = Guid.NewGuid();
            thirdProject.DateInsertedUtc = DateTime.UtcNow.AddDays(-10);
            thirdProject.ShortDescription = "Third project";
            thirdProject.LongDescription = "Long description of third project";
            
            projects.Add(firstProject);
            projects.Add(secondProject);
            projects.Add(thirdProject);
            context.Projects.AddRange(projects);

            context.RemoveRange(context.Scenarios);
            context.SaveChanges();

            List<Scenario> scenarios = new List<Scenario>();
            Scenario scenarioOne = new Scenario();
            scenarioOne.Id = Guid.NewGuid();
            scenarioOne.UriOne = "www.bbc.co.uk";
            scenarioOne.UriTwo = "www.cnn.com";

            Scenario scenarioTwo = new Scenario();
            scenarioTwo.Id = Guid.NewGuid();
            scenarioTwo.UriOne = "www.amazon.com";
            scenarioTwo.UriTwo = "www.microsoft.com";

            Scenario scenarioThree = new Scenario();
            scenarioThree.Id = Guid.NewGuid();
            scenarioThree.UriOne = "www.greatsite.com";
            scenarioThree.UriTwo = "www.nosuchsite.com";
            scenarioThree.UriThree = "www.neverheardofsite.com";

            scenarios.Add(scenarioOne);
            scenarios.Add(scenarioTwo);
            scenarios.Add(scenarioThree);
            context.Scenarios.AddRange(scenarios);

            context.RemoveRange(context.Loadtests);
            context.SaveChanges();

            List<Loadtest> loadtests = new List<Loadtest>();
            Loadtest ltOne = new Loadtest();
            ltOne.Id = Guid.NewGuid();
            ltOne.AgentId = amazon.Id;
            ltOne.CustomerId = niceCustomer.Id;
            ltOne.EngineerId = john.Id;
            ltOne.LoadtestTypeId = stressTest.Id;
            ltOne.DurationSec = 60;
            ltOne.StartDateUtc = DateTime.UtcNow;
            ltOne.UserCount = 10;
            ltOne.ProjectId = firstProject.Id;
            ltOne.ScenarioId = scenarioOne.Id;

            Loadtest ltTwo = new Loadtest();
            ltTwo.Id = Guid.NewGuid();
            ltTwo.AgentId = azure.Id;
            ltTwo.CustomerId = greatCustomer.Id;
            ltTwo.EngineerId = mary.Id;
            ltTwo.LoadtestTypeId = capacityTest.Id;
            ltTwo.DurationSec = 120;
            ltTwo.StartDateUtc = DateTime.UtcNow.AddMinutes(20);
            ltTwo.UserCount = 40;
            ltTwo.ProjectId = secondProject.Id;
            ltTwo.ScenarioId = scenarioThree.Id;

            Loadtest ltThree = new Loadtest();
            ltThree.Id = Guid.NewGuid();
            ltThree.AgentId = rackspace.Id;
            ltThree.CustomerId = okCustomer.Id;
            ltThree.EngineerId = fred.Id;
            ltThree.LoadtestTypeId = stressTest.Id;
            ltThree.DurationSec = 180;
            ltThree.StartDateUtc = DateTime.UtcNow.AddMinutes(30);
            ltThree.UserCount = 50;
            ltThree.ProjectId = thirdProject.Id;
            ltThree.ScenarioId = scenarioTwo.Id;

            loadtests.Add(ltOne);
            loadtests.Add(ltTwo);
            loadtests.Add(ltThree);
            context.Loadtests.AddRange(loadtests);

            context.SaveChanges();
        }
    }
}
