using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum DeviceType
    /// <summary>
    ///     Sisteme erişim sağlayan cihaz türlerini temsil eder.
    ///     Bu enum, özellikle kullanıcı girişlerinde, log kayıtlarında veya güvenlik
    ///     kontrollerinde istemcinin hangi tür cihazdan bağlandığını belirlemek için kullanılır.
    ///     
    ///     Uygulamanın farklı katmanları (Application, Infrastructure, API)
    ///     bu enum’ı kullanarak cihaz türüne göre davranış değiştirebilir.
    /// </summary>
    { 
        Windows,
        SmartDevice
    }

}
