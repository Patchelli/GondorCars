using GondorCars.Domain.Core.Interfaces.Repositories;
using GondorCars.Domain.Entities.Owner;

namespace GondorCars.Domain.Service
{
    public class ResponsibleOwnerService : ServiceBase<ResponsibleOwner>, IRepositoryResponsibleOwner
    {
        private readonly IRepositoryResponsibleOwner _repositoryResponsibleOwner;

        public ResponsibleOwnerService(IRepositoryResponsibleOwner repository) : base(repository)
        {
            this._repositoryResponsibleOwner = repository;
        }
    }
}
