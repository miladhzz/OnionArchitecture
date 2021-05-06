using CarFactory.Domain.Model;
using CF.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory.Domain
{
    public interface ICarRepository
    {
        void Create(Car entity);
        List<Car> GetAll();
        Car Get(int id);
        void Save();
        bool Exist(string model);
    }
}
