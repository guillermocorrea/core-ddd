using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.SharedKernel.Domain;

namespace WebSuiteDDD.Loadtesting.Domain
{
    public class LoadtestType : EntityBase<Guid>
    {
        public Description Description { get; private set; }

        public LoadtestType(Guid guid, string shortDescription, string longDescription)
            : base(guid)
        {
            Description = new Description(shortDescription, longDescription);
        }
    }
}
