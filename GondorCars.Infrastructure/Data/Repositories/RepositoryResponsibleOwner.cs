using GondorCars.Domain.Core.Interfaces.Repositories;
using GondorCars.Domain.Entities.Car;
using GondorCars.Domain.Entities.Owner;

namespace GondorCars.Infrastructure.Data.Repositories
{
    public class RepositoryResponsibleOwner : RepositoryBase<ResponsibleOwner>, IRepositoryResponsibleOwner
    {
        private readonly DataContext _dataContext;

        public RepositoryResponsibleOwner(DataContext dataContext) : base(dataContext)
        {
            this._dataContext = dataContext;
        }
    }
}
