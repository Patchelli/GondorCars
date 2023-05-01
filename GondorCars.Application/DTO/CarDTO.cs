using System;

namespace GondorCars.Application.DTO
{
    public class CarDTO
    {
        // Propriedades do carro
        public string Brand { get; set; }

        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string Chassis { get; set; }
        public string LicensePlate { get; set; }
        public int Mileage { get; set; }
        public DateTime DataRegister { get; set; }
        public double PriceBuy { get; set; }
        public double PriceSell { get; set; }
        public int NumberOfDoors { get; set; }
        public bool AirConditioning { get; set; }
        public bool PowerSteering { get; set; }
        public bool PowerWindows { get; set; }
        public bool PowerLocks { get; set; }
    }
}