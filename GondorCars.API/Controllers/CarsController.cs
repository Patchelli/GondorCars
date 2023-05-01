using GondorCars.Application.DTO;
using GondorCars.Application.Interface;
using GondorCars.Domain.Entities.Car;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GondorCars.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IApplicationServiceCar _applicationServiceCar;

        public CarsController(IApplicationServiceCar service)
        {
            _applicationServiceCar = service;
        }

        // GET: api/Cars
        [HttpGet]
        public ActionResult<IEnumerable<CarDTO>> GetCars()
        {
            return Ok(_applicationServiceCar.GetAll());
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public ActionResult<Car> GetCar(int id)
        {
            return Ok(_applicationServiceCar.GetById(id));
        }

        //// PUT: api/Cars/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCar(int id, Car car)
        //{
        //    if (id != car.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(car).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CarExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Cars
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Car>> PostCar(Car car)
        //{
        //    _context.Cars.Add(car);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCar", new { id = car.Id }, car);
        //}

        //// DELETE: api/Cars/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Car>> DeleteCar(int id)
        //{
        //    var car = await _context.Cars.FindAsync(id);
        //    if (car == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Cars.Remove(car);
        //    await _context.SaveChangesAsync();

        //    return car;
        //}

        //private bool CarExists(int id)
        //{
        //    return _context.Cars.Any(e => e.Id == id);
        //}
    }
}