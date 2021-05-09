using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Application.Contracts.Car
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string CreateTime { get;  set; }
        public bool IsDelete { get;  set; }
    }
}
