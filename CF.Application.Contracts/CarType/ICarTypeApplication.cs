using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Application.Contracts.CarType
{
    public interface ICarTypeApplication
    {
        CarTypeViewModel Get(int id);
    }
}
