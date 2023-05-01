using GondorCars.Application.DTO;
using GondorCars.Domain.Entities.Car;
using GondorCars.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GondorCars.Infrastructure.CrossCutting.Mapper
{
    public class MapperCar : IMapperCar
    {
        public Car MapperDtoToEntity(CarDTO carDto)
        {
            return new Car()
            {
                Brand = carDto.Brand,
                Model = carDto.Model,
                Year = carDto.Year,
                Color = carDto.Color,
                Chassis = carDto.Chassis,
                LicensePlate = carDto.LicensePlate,
                Mileage = carDto.Mileage,
                DataRegister = carDto.DataRegister,
                PriceBuy = carDto.PriceBuy,
                PriceSell = carDto.PriceSell,
                NumberOfDoors = carDto.NumberOfDoors,
                AirConditioning = carDto.AirConditioning,
                PowerSteering = carDto.PowerSteering,
                PowerWindows = carDto.PowerWindows,
                PowerLocks = carDto.PowerLocks,
            };
        }

        public IEnumerable<CarDTO> MapperDtoToListCars(IEnumerable<Car> cars)
        {
            var dto = cars.Select(c => new CarDTO { Id = c.Id });

            return dto;
        }

        public CarDTO MapperEntityToDto(Car car)
        {
            return new CarDTO
            {
                Brand = car.Brand,
                Model = car.Model,
                Year = car.Year,
                Color = car.Color,
                Chassis = car.Chassis,
                LicensePlate = car.LicensePlate,
                Mileage = car.Mileage,
                DataRegister = car.DataRegister,
                PriceBuy = car.PriceBuy,
                PriceSell = car.PriceSell,
                NumberOfDoors = car.NumberOfDoors,
                AirConditioning = car.AirConditioning,
                PowerSteering = car.PowerSteering,
                PowerWindows = car.PowerWindows,
                PowerLocks = car.PowerLocks,
            };
        }
    }
}