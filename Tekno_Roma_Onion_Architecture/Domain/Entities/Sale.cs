using Domain.Entities.Teknoroma.Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sale : BaseEntity
    /// <summary> 
    ///     Satış işlemlerini temsil eden entity sınıfı
    /// </summary>
    {
        public string SaleNumber { get; set; }
        /// <summary>
        ///     Satışların benzersiz numarası için oluşturuldu. Bu numara ile cep bilgisayarından satış yapan personelin oluşturmuş olduğu salenummer sayesinde satışa ait detaylar kasiyer tarafında görüntülenebilecek.
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        ///     toplam satış tutarı verisi.
        /// </summary>
        public DeviceType DeviceType { get; set; }
        /// <summary>
        ///     Devicetype enumundan gelir. Satışın hangi cihazdan yapıldığını belirtir.
        /// </summary>

        public int CustomerId { get; set; }
        /// <summary>
        ///     CustomerId foreing key olarak tanımlandı.
        /// </summary>
        public Customer Customer { get; set; }
        /// <summary>
        ///     Satışın yapıldığı müşteri için ilişki tanımlandı.
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        ///     EmployeeId foreing key olarak tanımlandı.
        /// </summary>
        public Employee Employee { get; set; }
        /// <summary>
        ///     Satışı gerçekleştiren çalışan için ilişki tanımlandı.
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        ///     Satışın yapıldığı mağaza foreign key olarak tanımlandı.
        /// </summary>
        public Store Store { get; set; }
        /// <summary>
        ///     Satışın yapıldığı mağaza için ilişki tanımlandı.
        /// </summary>

        public ICollection<SaleItem> Items { get; set; }
        /// <summary>
        ///     Satışa ait ürünleri temsil eden koleksiyon.
        /// ICollection kullanıyoruz çünkü domain modeli bağımsız, esnek ve EF Core uyumlu olsun istiyoruz. List yazmak, domain’i gereksiz yere bir implementasyona kilitler.
        /// </summary>
    }

}
