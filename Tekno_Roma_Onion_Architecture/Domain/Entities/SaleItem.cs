using Domain.Entities.Teknoroma.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SaleItem : BaseEntity
    /// <summary>
    /// Satış kalemini temsil eder. Bir satışın içerisinde yer alan her bir ürün için ayrı bir SaleItem kaydı oluşturulur.
    /// </summary>
    {
        public int SaleId { get; set; }
        /// </summary>
        ///     Hangi satışa ait olduğunu belirtmek için SaleId foreign key olarak tanımlandı.
        /// </summary>
        public Sale Sale { get; set; }
        /// <summary>
        ///     Hangi satışa ait olduğunu belirtmek için Sale entity ile ilişki tanımlandı.
        /// </summary>

        public int ProductId { get; set; }
        /// </summary>
        ///     Hangi ürüne ait olduğunu belirtmek için ProductId foreign key olarak tanımlandı.
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        ///     Hangi ürüne ait olduğunu belirtmek için Product entity ile ilişki tanımlandı.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        ///     Adedi belirtir.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///     Fiyatı belirtir.
        /// </summary>
    }

}
