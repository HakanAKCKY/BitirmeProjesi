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
        /// <summary>
        ///     Mağaza adı
        /// </summary>
        public string City { get; set; }
        /// <summary>
        ///     Mağaza şehir bilgisi.
        /// </summary>
        public ICollection<Employee> Employees { get; set; }
        /// <summary>
        ///     Mağazada çalışan personel bilgileri. One to many ilişki.
        /// </summary>
        public ICollection<Sale> Sales { get; set; }
        /// <summary>
        ///     Mağazada gerçekleştirilen satış işlemleri. One to many ilişki.
        /// </summary>
    }


}
