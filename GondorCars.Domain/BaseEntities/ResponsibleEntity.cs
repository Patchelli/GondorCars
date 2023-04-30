using GondorCars.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace GondorCars.Domain.BaseEntities
{
    public class ResponsibleEntity : Base
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public TypeOwnerEnum TypeOwner { get; set; }
    }
}
