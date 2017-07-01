using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Repository.EF.DataModel
{
    public class Loadtest : LoadtestParameters // work-around for complex types, ef core doesn't still supports it.
    {
        public Guid Id { get; set; }
        public Guid AgentId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? EngineerId { get; set; }
        public Guid LoadtestTypeId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid ScenarioId { get; set; }
        // public LoadtestParameters Parameters { get; set; }
    }
}
