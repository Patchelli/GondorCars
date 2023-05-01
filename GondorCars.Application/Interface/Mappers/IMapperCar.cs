using GondorCars.Application.DTO;
using GondorCars.Domain.Entities.Car;
using System.Collections.Generic;

namespace GondorCars.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperCar
    {
        Car MapperDtoToEntity(CarDTO carDto);

        IEnumerable<CarDTO> MapperDtoToListCars(IEnumerable<Car> cars);

        CarDTO MapperEntityToDto(Car car);
    }
}