using GondorCars.Application.DTO;
using GondorCars.Domain.Entities.Car;
using System.Collections.Generic;

namespace GondorCars.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperAccessory
    {
        Accessory MapperDtoToEntity(AccessoryDTO accessoryDto);

        IEnumerable<AccessoryDTO> MapperDtoToListAccessories(IEnumerable<Accessory> accessories);

        AccessoryDTO MapperEntityToDto(Accessory accessory);
    }
}