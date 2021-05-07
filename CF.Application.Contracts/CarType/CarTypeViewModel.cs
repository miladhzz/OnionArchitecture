using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Application.Contracts.CarType
{
    public class CarTypeViewModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsDeleted { get; private set; }
        public string CreateTime { get; private set; }
    }
}
