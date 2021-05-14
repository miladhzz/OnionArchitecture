using CarFactory.Domain.CarDomain.Exceptions;

namespace CarFactory.Domain.CarDomain.Services
{
    public class CarValidationService : ICarValidationService
    {
        private readonly ICarRepository _carRepository;

        public CarValidationService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void CheckCarModelIsExist(string model)
        {
            if (_carRepository.Exist(x => x.Model == model))
                throw new DuplicateCarException("Model is exists");
        }
    }
}
