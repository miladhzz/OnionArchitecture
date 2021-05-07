using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Application.Contracts.CarType
{
    public class CarTypeViewModel
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public bool IsDeleted { get;  set; }
        public string CreateTime { get;  set; }
    }
}
