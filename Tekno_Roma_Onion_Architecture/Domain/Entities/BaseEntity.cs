using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    namespace Teknoroma.Domain.Common
    {
        /// <summary>
        /// Temel varlık sınıfı için oluşturuldu kod tekrarının önüne geçiyor tüm entityler bu sınıftan miras alır.
        /// </summary>
        public abstract class BaseEntity
        {
            public int Id { get; set; }
            /// <summary>
            ///  oluşturulma tarihi
            ///  DateTime.UtcNow olarak yazma sebebebim ortak bir zaman dilimi kullanmak için. tüm sistemlerde tutarlıdır.
            /// </summary>
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
            /// <summary>
            /// güncelleme tarihi boş bırakılabilir null olabilir.
            /// </summary>
            public DateTime? UpdatedAt { get; set; }
            /// <summary>
            ///  silme işlemi için aktiflik durumu
            /// </summary>
            public bool IsActive { get; set; } = true;
        }

    }
}
