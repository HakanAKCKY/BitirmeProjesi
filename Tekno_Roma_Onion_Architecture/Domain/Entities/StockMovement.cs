using Domain.Entities.Teknoroma.Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StockMovement : BaseEntity
    {
        public int ProductId { get; set; }
        /// <summary>
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
        public StockMovementType MovementType { get; set; }
        /// <summary>
        ///     Bu property, bir ürünün stok değişiminin hangi sebebden gerçekleştiğini belirtir. Neden arttı neden azaldı bunun için enum kullanırız
        /// </summary>

        public int SupplierId { get; set; }
        /// <summary>
        ///     Hangi tedarikçiye ait olduğunu belirtmek için SupplierId foreign key olarak tanımlandı.
        /// </summary>
        public Supplier Supplier { get; set; }
        /// <summary>
        ///     Hangi tedarikçiye ait olduğunu belirtmek için Supplier entity ile ilişki tanımlandı.
        /// </summary>
    }

}
