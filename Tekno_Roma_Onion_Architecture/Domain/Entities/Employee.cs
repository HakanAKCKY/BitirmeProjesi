using Domain.Entities.Teknoroma.Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FullName { get; set; }
      
        public string Username { get; set; }
        /// <summary>
        /// Username çalışan girişleri için benzersiz olmalıdır. Login işlemlerinde kullanılacak.
        /// </summary>
        public string PasswordHash { get; set; }
        /// <summary>
        /// Güvenlik için şifreyi asla düz metin (plain text) kaydetmiyoruz.
        /// </summary>
        public UserRole Role { get; set; }
        /// <summary>
        /// Çalışanın yetki sınıfını temsil eder,Enumlardan gelir.
        /// </summary>

        public int StoreId { get; set; }
        /// <summary>
        /// Çalışanın hangi mağazada çalıştığını belirtir, projede Tekroma çoklu mağaza yapısı olduğu için eklendi.
        /// yani birçok çalışan bir mağazada çalışabilir.
        /// </summary>
        public Store Store { get; set; }
        /// <summary>
        /// çalışanın bağlı olduğu mağaza
        /// yani birçok çalışan bir mağazada çalışabilir.
        /// </summary>
        public ICollection<Sale> Sales { get; set; }
        /// <summary>
        /// Çalışanın yaptığı satışları temsil eder. bir çalışanın birden çok satışı olabilir buda one to many ilişkiyi gösterir.
        /// </summary>
    }

}
