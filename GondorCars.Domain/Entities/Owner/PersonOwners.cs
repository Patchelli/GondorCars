using System;
using System.Collections.Generic;
using System.Text;
using GondorCars.Shared.Enum;

namespace GondorCars.Domain.Entities.Owner
{
    public class PersonOwners : ResponsibleOwner
    {
        public string CPF { get; set; }
        public GenderEnum Sexy { get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
