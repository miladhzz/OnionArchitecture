using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory.Generics
{
    public class DomainBase<T>
    {
        public T Id { get; private set; }
        public DateTime CreateTime { get; private set; }

        public DomainBase()
        {
            CreateTime = DateTime.Now;
        }

    }
}
