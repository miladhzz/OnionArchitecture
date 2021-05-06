using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Application.Contracts
{
    public interface ICarApplication
    {
        List<CarViewModel> List();
        void Create(CreateCar command);
        void Rename(RenameCar command);
        RenameCar Get(int id);
        void Remove(int id);
        void Activate(int id);
    }
}
