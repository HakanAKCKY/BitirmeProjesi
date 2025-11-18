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
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public StockMovementType MovementType { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }

}
