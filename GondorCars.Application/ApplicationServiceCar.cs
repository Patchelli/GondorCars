using GondorCars.Application.DTO;
using GondorCars.Application.Interface;
using GondorCars.Domain.Core.Interfaces.Services;
using GondorCars.Infrastructure.CrossCutting.Interfaces;
using System.Collections.Generic;

namespace GondorCars.Application
{
    public class ApplicationServiceCar : IApplicationServiceCar
    {
        private readonly ICarService carService;
        private readonly IMapperCar mapperCar;

        public ApplicationServiceCar(ICarService carService, IMapperCar mapperCar)
        {
            this.carService = carService;
            this.mapperCar = mapperCar;
        }

        public void Add(CarDTO carDto)
        {
            var car = mapperCar.MapperDtoToEntity(carDto);
            carService.Add(car);
        }

        public IEnumerable<CarDTO> GetAll()
        {
            var cars = carService.GetAll();

            return mapperCar.MapperDtoToListCars(cars);
        }

        public CarDTO GetById(int id)
        {
            var car = carService.GetById(id);

            return mapperCar.MapperEntityToDto(car);
        }

        public void Remove(CarDTO carDto)
        {
            var car = mapperCar.MapperDtoToEntity(carDto);
            carService.Remove(car);
        }

        public void Update(CarDTO carDto)
        {
            var car = mapperCar.MapperDtoToEntity(carDto);
            carService.Update(car);
        }
    }
}