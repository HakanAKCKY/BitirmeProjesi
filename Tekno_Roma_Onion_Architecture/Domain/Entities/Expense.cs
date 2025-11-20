using Domain.Entities.Teknoroma.Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Expense : BaseEntity
    /// <summary>
    ///     Gül Satar (muhasebeci) tarafından istenen harcamaları tutmak için oluşturuldu.
    /// </summary>
    {
        public ExpenseType ExpenseType { get; set; }
        /// <summary>
        ///     Harcama türünü belirtir.Enum olarak tanımlandı.
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        ///     Harcama tutarı verisi.
        /// </summary>
        public DateTime ExpenseDate { get; set; }
        /// <summary>
        ///     Harcama tarihi verisi.
        /// </summary>
    }

}
