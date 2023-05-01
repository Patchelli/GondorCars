using GondorCars.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GondorCars.Application.Interface
{
    public interface IApplicationServiceResponsibleOwner
    {
        void Add(ResponsibleOwnerDTO responsibleOwnerDto);

        void Update(ResponsibleOwnerDTO responsibleOwnerDto);

        void Remove(ResponsibleOwnerDTO responsibleOwnerDto);

        IEnumerable<ResponsibleOwnerDTO> GetAll();

        ResponsibleOwnerDTO GetById(int id);
    }
}
