using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.SharedKernel.Domain;

namespace WebSuiteDDD.Loadtesting.Domain
{
    public class Project : EntityBase<Guid>
    {
        public Description Description { get; private set; }

        public Project(Guid id, string shortDescription, string longDescription) : base(id)
        {
            Description = new Description(shortDescription, longDescription);
        }
    }
}
