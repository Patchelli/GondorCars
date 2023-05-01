using GondorCars.Domain.Core.Interfaces.Repositories;
using GondorCars.Domain.Entities.Car;

namespace GondorCars.Infrastructure.Data.Repositories
{
    public class RepositoryAccessory : RepositoryBase<Accessory>, IRepositoryAccessory
    {
        private readonly DataContext _dataContext;
        public RepositoryAccessory(DataContext dataContext) : base(dataContext)
        {
            this._dataContext = dataContext;
        }
    }
}
