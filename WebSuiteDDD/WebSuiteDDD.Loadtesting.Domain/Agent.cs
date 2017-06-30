using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.SharedKernel.Domain;

namespace WebSuiteDDD.Loadtesting.Domain
{
    public class Agent : EntityBase<Guid>
    {
        public Location Location { get; private set; }

        public Agent(Guid id, string city, string country)
            : base(id)
        {
            Location = new Location(city, country);
        }
    }
}
