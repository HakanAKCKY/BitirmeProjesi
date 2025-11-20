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
        public decimal TotalAmount { get; set; }
        public DeviceType DeviceType { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public ICollection<SaleItem> Items { get; set; }
    }

}
