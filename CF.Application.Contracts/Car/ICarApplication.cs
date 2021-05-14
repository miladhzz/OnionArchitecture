using System.Collections.Generic;

namespace CF.Application.Contracts.Car
{
    public interface ICarApplication
    {
        List<CarViewModel> GetAll();        
        void Create(CreateCar command);
        void Rename(RenameCar command);
        CarViewModel Get(int id);
        CarViewModel CarInfo(int id);
        void Remove(int id);
        void Activate(int id);
    }
}
