using Domain.Entities.Teknoroma.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        /// <summary>
        /// Category entity Product ile bire çok ilişki içerisindedir. One to many.
        /// </summary>
        public ICollection<Product> Products { get; set; }
    }

}
