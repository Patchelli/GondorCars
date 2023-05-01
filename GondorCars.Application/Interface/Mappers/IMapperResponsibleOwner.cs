using GondorCars.Application.DTO;
using GondorCars.Domain.Entities.Owner;
using System.Collections.Generic;

namespace GondorCars.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperResponsibleOwner
    {
        ResponsibleOwner MapperDtoToEntity(ResponsibleOwnerDTO responsibleOwnerDto);

        IEnumerable<ResponsibleOwnerDTO> MapperDtoToListResponsibleOwner(IEnumerable<ResponsibleOwner> responsibleOwners);

        ResponsibleOwnerDTO MapperEntityToDto(ResponsibleOwner responsibleOwner);
    }
}