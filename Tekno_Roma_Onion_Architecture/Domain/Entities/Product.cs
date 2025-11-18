using Domain.Entities.Teknoroma.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CriticalLevel { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public ICollection<SaleItem> SaleItems { get; set; }
        public ICollection<StockMovement> StockMovements { get; set; }
    }

}
