using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum Gender
    /// <summary>
    ///     Bu enum, sistemdeki kullanıcıların veya çalışanların cinsiyet bilgilerini temsil eder.
    ///     "Unknown" değeri, kişi cinsiyetinin belirtilmediği veya sistem tarafından henüz belirlenmediği durumlar için güvenli bir varsayılan değer olarak eklenmiştir.
    /// </summary>
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }

}
