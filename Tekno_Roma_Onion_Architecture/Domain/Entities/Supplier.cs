using Domain.Entities.Teknoroma.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        /// <summary>
        ///    Tedarikçi adı
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        ///     tedarikçi telefon numarası
        /// </summary>

        public ICollection<Product> Products { get; set; }
        /// <summary>
        ///     Tedarikçi ile ürünler arasındaki ilişki. One to many ilişki.
        /// </summary>
    }
}

