using System;
using System.Collections.Generic;
using System.Text;

namespace GondorCars.Domain.Entities.Owner
{
    public class OrganizationOwners : ResponsibleOwner
    {
        public string CNPJ { get; set; }
    }
}
