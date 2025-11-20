using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    namespace Teknoroma.Domain.Common
    {
       
        public abstract class BaseEntity
        /// <summary>
        /// Temel varlık sınıfı için oluşturuldu kod tekrarının önüne geçiyor tüm entityler bu sınıftan miras alır.
        /// </summary>
        {
            public int Id { get; set; }
           
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
            /// <summary>
            ///  oluşturulma tarihi
            ///  DateTime.UtcNow olarak yazma sebebebim ortak bir zaman dilimi kullanmak için. tüm sistemlerde tutarlıdır.
            /// </summary>
            public DateTime? UpdatedAt { get; set; }
            /// <summary>
            /// güncelleme tarihi boş bırakılabilir null olabilir.
            /// </summary>
            public bool IsActive { get; set; } = true;
            /// <summary>
            /// silme işlemi için aktiflik durumu
            /// </summary>
        }

    }
}
