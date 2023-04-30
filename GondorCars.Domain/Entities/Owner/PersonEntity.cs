using System;
using System.Collections.Generic;
using System.Text;
using GondorCars.Domain.BaseEntities;
using GondorCars.Shared.Enum;

namespace GondorCars.Domain.Entities.Owner
{
    public class PersonEntity : ResponsibleEntity
    {
        public string CPF { get; set; }
        public GenderEnum Sexy { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
