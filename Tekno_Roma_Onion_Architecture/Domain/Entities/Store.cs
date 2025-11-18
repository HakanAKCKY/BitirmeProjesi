using Domain.Entities.Teknoroma.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }

  
}
