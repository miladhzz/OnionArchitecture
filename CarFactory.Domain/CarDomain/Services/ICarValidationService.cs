namespace CarFactory.Domain.CarDomain.Services
{
    public interface ICarValidationService
    {
        void CheckCarModelIsExist(string model);
    }
}
