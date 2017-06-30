using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.SharedKernel.Domain;

namespace WebSuiteDDD.Loadtesting.Domain
{
    public class Customer : EntityBase<Guid>
    {
        public string Name { get; private set; }

        public Customer(Guid guid, string name) : base(guid)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Customer name");
            Name = name;
        }

        // Part of Administration context, LoadTest context doesn't care about changing customer's name.
        //public void ModifyName(string newName)
        //{
        //    if (string.IsNullOrEmpty(newName)) throw new ArgumentNullException("Customer name");
        //    Name = newName;
        //}
    }
}
