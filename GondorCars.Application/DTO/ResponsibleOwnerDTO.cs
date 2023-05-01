using GondorCars.Domain.BaseEntities;
using GondorCars.Shared.Enum;
using System;

namespace GondorCars.Application.DTO
{
    public class ResponsibleOwnerDTO
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public DateTime DataRegister { get; set; }
        public TypeOwnerEnum TypeOwner { get; set; }
    }
}