using GondorCars.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GondorCars.Application.Interface
{
    public interface IApplicationServiceAccessory
    {
        void Add(AccessoryDTO accessoryDto);

        void Update(AccessoryDTO accessoryDto);

        void Remove(AccessoryDTO accessoryDto);

        IEnumerable<AccessoryDTO> GetAll();

        AccessoryDTO GetById(int id);
    }
}
