using GondorCars.Application.DTO;
using System.Collections.Generic;

namespace GondorCars.Application.Interface
{
    public interface IApplicationServiceCar
    {
        void Add(CarDTO carDto);

        void Update(CarDTO carDto);

        void Remove(CarDTO carDto);

        IEnumerable<CarDTO> GetAll();

        CarDTO GetById(int id);
    }
}