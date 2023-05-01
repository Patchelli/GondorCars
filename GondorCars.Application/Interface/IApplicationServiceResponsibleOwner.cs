using GondorCars.Application.DTO;
using System.Collections.Generic;

namespace GondorCars.Application.Interface
{
    public interface IApplicationServiceResponsibleOwner
    {
        void Add(ResponsibleOwnerDTO responsibleOwnerDto);

        void Update(ResponsibleOwnerDTO responsibleOwnerDto);

        void Remove(ResponsibleOwnerDTO rINesponsibleOwnerDto);

        IEnumerable<ResponsibleOwnerDTO> GetAll();

        ResponsibleOwnerDTO GetById(int id);
    }
}