using GondorCars.Domain.Core.Interfaces.Repositories;
using GondorCars.Domain.Core.Interfaces.Services;
using GondorCars.Domain.Entities.Car;

namespace GondorCars.Domain.Service
{
    public class AccessoryService : ServiceBase<Accessory>, IAccessoryService
    {
        private readonly IRepositoryAccessory _repositoryAccessory;

        public AccessoryService(IRepositoryAccessory repositoryAccessory) : base(repositoryAccessory)
        {
            this._repositoryAccessory = repositoryAccessory;
        }
    }
}