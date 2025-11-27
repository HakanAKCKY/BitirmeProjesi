using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    /// <summary>
    ///     İşletmede oluşan gider kategorilerini temsil eder.
    ///     Bu enum, finansal işlemlerin sınıflandırılmasını sağlar ve
    ///     giderlerin raporlanması, analiz edilmesi ve iş kurallarının
    ///     doğru şekilde uygulanması için temel bir yapı sunar.
    ///
    ///     Bu kategoriler, sistemde kayıt altına alınan bir harcamanın
    ///     hangi tipte olduğunu belirleyerek finansal modülün
    ///     daha düzenli ve yönetilebilir olmasına yardımcı olur.
    /// </summary>
    public enum ExpenseType
    {
        /// <summary>
        ///     Personellere yapılan maaş, prim veya ek ödemeler.
        /// </summary>
        EmployeePayment,

        /// <summary>
        ///     Teknik ekipman, yazılım, bakım veya onarım gibi teknik harcamalar.
        /// </summary>
        TechnicalCost,

        /// <summary>
        ///     Elektrik, su, internet vb. düzenli fatura giderleri.
        /// </summary>
        Bills,

        /// <summary>
        ///     Belirli bir kategoriye girmeyen diğer tüm harcamalar.
        /// </summary>
        Other
    }


}
