using GondorCars.Application.DTO;
using System.Collections.Generic;

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