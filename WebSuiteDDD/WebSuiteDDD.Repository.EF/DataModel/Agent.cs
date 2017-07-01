using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.Repository.EF.DataModel
{
    public class Agent : Location
    {
        public Guid Id { get; set; }
        // public Location Location { get; set; }
    }
}
