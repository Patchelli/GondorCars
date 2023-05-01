using System;
using System.Collections.Generic;
using System.Text;

namespace GondorCars.Domain.BaseEntities
{
    public class Contact : Base
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
