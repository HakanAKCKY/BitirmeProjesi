using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    /// <summary>
    ///     Sistemdeki kullanıcıların sahip olabileceği rol ve görevleri temsil eder.
    ///     Bu enum, yetkilendirme, erişim kontrolü, iş akışı yönetimi ve
    ///     operasyonel sorumlulukların ayrıştırılması gibi kritik alanlarda
    ///     kullanılır.
    ///     
    ///     Domain katmanında tanımlanmasının temel nedeni, kullanıcıların
    ///     sistemde hangi yetkilere sahip olacağını belirleyen iş kurallarının
    ///     tüm katmanlarda tutarlı şekilde uygulanmasını sağlamaktır.
    ///     
    ///     Her rol, işletme içerisindeki bir görevi veya departmanı temsil eder:
    ///     - BranchManager: Şube yöneticisi, operasyon ve yetki yönetimi.
    ///     - Cashier: Ödeme alma, satış tamamlama gibi kasa işlemleri.
    ///     - MobileSales: Dış saha satış personeli, mobil cihaz üzerinden sipariş işlemleri.
    ///     - Warehouse: Depo personeli, stok giriş-çıkış, ürün yönetimi.
    ///     - Accounting: Muhasebe süreçleri, mali kayıtlar ve raporlama.
    ///     - TechnicalService: Teknik servis süreçleri, arıza kayıtları ve çözümler.
    ///     
    ///     Bu yapı, uygulamada rol tabanlı erişim (Role-Based Access Control) 
    ///     ve iş süreçlerinin ayrıştırılması adına temel bir bileşen görevi görür.
    /// </summary>
    public enum UserRole
    {
        /// <summary>
        ///     Şube yöneticisi rolü. Haluk SAYGIN= Şube Müdürü
        /// </summary>
        BranchManager,

        /// <summary>
        ///     Kasa işlemlerini gerçekleştiren kullanıcı. Gül SATAR= Kasa Satış Temsilcisi
        /// </summary>
        Cashier,

        /// <summary>
        ///     Sahada mobil satış yapan personel. Fahri CEPÇİ= Mobil Satış Temsilcisi
        /// </summary>
        MobileSales,

        /// <summary>
        ///     Depo süreçlerinden sorumlu kullanıcı. Kerim ZULACI= Depo Temsilcisi
        /// </summary>
        Warehouse,

        /// <summary>
        ///     Muhasebe işlemlerini yürüten kullanıcı. Feyza PARAGÖZ= Muhasebe Temsilcisi
        /// </summary>
        Accounting,

        /// <summary>
        ///     Teknik servis süreçlerini yöneten kullanıcı. Özgün KABLOCU= Teknik Servis Temsilcisi
        /// </summary>
        TechnicalService
    }


}
