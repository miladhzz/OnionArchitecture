using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Application.Contracts
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Createtime { get;  set; }
        public bool IsDelete { get;  set; }
    }
}
