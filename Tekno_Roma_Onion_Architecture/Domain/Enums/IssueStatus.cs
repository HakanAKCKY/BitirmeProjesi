using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    /// <summary>
    ///     Sistem içerisindeki bir teknik sorun, talep veya iş kaydının
    ///     mevcut durumunu ifade eder. 
    ///     
    ///     Bu enum, özellikle teknik destek, bakım süreçleri,
    ///     arıza takibi veya operasyonel süreçlerde bir işin hangi aşamada
    ///     olduğunu belirlemek için kullanılır.
    ///     
    ///     İş mantığı açısından örneğin:
    ///     - Pending: Sorun oluşturulmuş ancak henüz çözülmemiş.
    ///     - Completed: Sorun başarıyla çözülmüş ve süreç kapanmış.
    ///     - Failed: Çözüm girişimi yapılmış ancak başarısız olunmuş
    ///       veya süreç bir hata nedeniyle tamamlanamamış.
    ///
    ///     Bu durum bilgisi, raporlama, süreç ilerleme takibi, 
    ///     kullanıcı bilgilendirmeleri ve operasyon yönetimi için kritik öneme sahiptir.
    /// </summary>
    public enum IssueStatus
    {
        /// <summary>
        ///     İşlem veya sorun henüz çözülmeyi bekliyor.
        /// </summary>
        Pending,

        /// <summary>
        ///     İşlem başarıyla tamamlandı.
        /// </summary>
        Completed,

        /// <summary>
        ///     İşlem bir hata nedeniyle tamamlanamadı.
        /// </summary>
        Failed
    }


}
