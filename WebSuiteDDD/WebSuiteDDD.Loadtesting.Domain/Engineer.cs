using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.SharedKernel.Domain;

namespace WebSuiteDDD.Loadtesting.Domain
{
    public class Engineer : EntityBase<Guid>
    {
        public string Name { get; private set; }

        public Engineer(Guid guid, string name) : base(guid)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Engineer name");
            Name = name;
        }
    }
}
