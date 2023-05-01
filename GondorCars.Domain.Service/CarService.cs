using GondorCars.Domain.Core.Interfaces.Repositories;
using GondorCars.Domain.Core.Interfaces.Services;
using GondorCars.Domain.Entities.Car;

namespace GondorCars.Domain.Service
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        private readonly IRepositoryCar _repositoryCar;

        public CarService(IRepositoryCar repositoryCar) : base(repositoryCar)
        {
            this._repositoryCar = repositoryCar;
        }
    }
}