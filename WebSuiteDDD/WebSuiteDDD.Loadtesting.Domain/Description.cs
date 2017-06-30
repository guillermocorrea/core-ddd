using System;
using System.Collections.Generic;
using System.Text;
using WebSuiteDDD.SharedKernel.Domain;

namespace WebSuiteDDD.Loadtesting.Domain
{
    public class Description : ValueObjectBase<Description>
    {
        public string ShortDescription { get; private set; }
        public string LongDescription { get; private set; }

        public Description(string shortDescription, string longDescription)
        {
            if (string.IsNullOrEmpty(shortDescription)) throw new ArgumentNullException("Short description");
            if (string.IsNullOrEmpty(longDescription)) throw new ArgumentNullException("Long description");
            ShortDescription = shortDescription;
            LongDescription = longDescription;
        }

        public Description WithShortDescription(string shortDescription)
        {
            return new Description(shortDescription, this.LongDescription);
        }

        public Description WithLongDescription(string longDescription)
        {
            return new Description(this.ShortDescription, longDescription);
        }

        public override bool Equals(Description other)
        {
            return this.ShortDescription.Equals(other.ShortDescription, StringComparison.OrdinalIgnoreCase)
                && this.LongDescription.Equals(other.LongDescription, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Description)) return false;
            return this.Equals((Description)obj);
        }

        public override int GetHashCode()
        {
            return this.LongDescription.GetHashCode() + this.ShortDescription.GetHashCode();
        }
    }
}
