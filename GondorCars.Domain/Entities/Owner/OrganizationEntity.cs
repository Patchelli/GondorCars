using System;
using System.Collections.Generic;
using System.Text;
using GondorCars.Domain.BaseEntities;

namespace GondorCars.Domain.Entities.Owner
{
    public class OrganizationEntity : ResponsibleEntity
    {
        public string CNPJ { get; set; }
    }
}
