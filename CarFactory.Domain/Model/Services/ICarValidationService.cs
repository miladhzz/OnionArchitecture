namespace CarFactory.Domain.Model.Services
{
    public interface ICarValidationService
    {
        void CheckCarModelIsExist(string model);
    }
}
