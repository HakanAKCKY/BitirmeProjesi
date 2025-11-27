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
        /// Gender cinsiyet enum olarak tanımlandı.
        /// Haluk beyin istemiş olduğu satış takip raporunun, müşteri kitlesi ve yaşı bilgisi için eklendi.
        /// </summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Doğum Tarihi
        /// NEDEN? Yaş analizi için (Haluk Bey'in raporu)
        /// </summary>

        public int? Age => BirthDate.HasValue
            ? DateTime.Now.Year - BirthDate.Value.Year
            : null;
        /// <summary>
        /// Müşterinin yaşı
        /// BirthDate'den hesaplanır
        /// </summary>
        public ICollection<Sale> Sales { get; set; }
    }  /// <summary>
       /// Customer sales ile bire çok ilişki içerisindedir. One to many 
       /// </summary>

}
