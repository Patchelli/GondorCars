using GondorCars.Shared.Enum;
using System;

namespace GondorCars.Domain.Entities.Owner
{
    public class PersonOwners : ResponsibleOwner
    {
        public string CPF { get; set; }
        public GenderEnum Sexy { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}