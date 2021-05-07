using System.Collections.Generic;

namespace CF.Application.Contracts.Car
{
    public interface ICarApplication
    {
        List<CarViewModel> List();
        void Create(CreateCar command);
        void Rename(RenameCar command);
        CarViewModel Get(int id);
        void Remove(int id);
        void Activate(int id);
    }
}
