using GondorCars.Domain.Core.Interfaces.Repositories;
using GondorCars.Domain.Entities.Car;

namespace GondorCars.Infrastructure.Data.Repositories
{
    public class RepositoryCar : RepositoryBase<Car>, IRepositoryCar
    {
        private readonly DataContext _dataContext;
        public RepositoryCar(DataContext dataContext) : base(dataContext)
        {
            this._dataContext = dataContext;
        }
    }
}
