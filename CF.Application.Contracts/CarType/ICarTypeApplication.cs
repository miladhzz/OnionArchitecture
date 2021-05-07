using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Application.Contracts.CarType
{
    public interface ICarTypeApplication
    {
        List<CarTypeViewModel> GetAll();
        void Create(CarTypeCreate command);
        void Rename(CarTypeRename command);
        CarTypeViewModel Get(int id);
        void Remove(int id);
        void Activate(int id);
    }
}
