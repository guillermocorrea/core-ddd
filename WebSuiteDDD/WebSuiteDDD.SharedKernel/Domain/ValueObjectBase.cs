using System;
using System.Collections.Generic;
using System.Text;

namespace WebSuiteDDD.SharedKernel.Domain
{
    public abstract class ValueObjectBase<T> : IEquatable<T> where T : ValueObjectBase<T>
    {
        public abstract bool Equals(T other);
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
    }
}
