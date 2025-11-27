using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    /// <summary>
    ///     Stok üzerinde gerçekleşen hareket türlerini temsil eder.
    ///     Bu enum, ürünlerin stok giriş-çıkış süreçlerini doğru şekilde
    ///     sınıflandırmak ve stok yönetimini iş kurallarına uygun şekilde
    ///     yürütmek için kullanılır.
    ///     
    ///     Domain katmanında tanımlanmasının amacı, stok hareketleri ile
    ///     ilgili tüm iş mantığının (örneğin stok arttırma, azaltma, iade
    ///     işlemlerinin nasıl ele alınacağı) tek bir merkezî yapı üzerinden
    ///     yönetilmesini sağlamaktır.
    ///     
    ///     Bu hareket türleri, stok miktarını etkileyen operasyonların
    ///     raporlanması, kontrol edilmesi ve muhasebe/operasyon süreçlerinde
    ///     tutarlılık sağlanması için kritik öneme sahiptir.
    ///     
    ///     Hareket tiplerinin temel anlamları:
    ///     - Purchase: Ürün satın alımı veya depo giriş işlemleri.
    ///     - Sale: Ürün satışı veya stoktan çıkış işlemleri.
    ///     - Return: Müşteri iadesi veya tedarikçiye yapılan iade
    ///       işlemleri gibi, stok miktarını artıran veya azaltan geri dönüşler.
    /// </summary>
    public enum StockMovementType
    {
        /// <summary>
        ///     Stok arttıran satın alma veya giriş işlemleri.
        /// </summary>
        Purchase,

        /// <summary>
        ///     Satış veya stoktan çıkış işlemleri.
        /// </summary>
        Sale,

        /// <summary>
        ///     Ürün iadeleri (müşteri tarafından veya tedarikçiye doğru).
        /// </summary>
        Return
    }


}
