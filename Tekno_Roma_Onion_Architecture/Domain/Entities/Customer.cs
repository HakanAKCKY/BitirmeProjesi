using Domain.Entities.Teknoroma.Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {

        public string FullName { get; set; }
        /// <summary>
        /// müşteri tam adı
        /// </summary>
        public string TCKN { get; set; }

        public Gender Gender { get; set; }
        /// <summary>
        /// gender cinsiyet enum olarak tanımlandı.
        /// Haluk beyin istemiş olduğu satış takip raporunun, müşteri kitlesi ve yaşı bilgisi için eklendi.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Haluk beyin istemiş olduğu satış takip raporunun, müşteri kitlesi ve yaşı bilgisi için eklendi.
        /// </summary>
        public ICollection<Sale> Sales { get; set; }
    }  /// <summary>
       /// Customer sales ile bire çok ilişki içerisindedir. One to many 
       /// </summary>

}
