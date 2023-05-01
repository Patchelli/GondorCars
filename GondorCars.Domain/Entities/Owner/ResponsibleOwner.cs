using GondorCars.Domain.BaseEntities;
using GondorCars.Shared.Enum;
using System;

namespace GondorCars.Domain.Entities.Owner
{
    public class ResponsibleOwner : Base
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public DateTime DataRegister { get; set; }
        public TypeOwnerEnum TypeOwner { get; set; }
    }
}