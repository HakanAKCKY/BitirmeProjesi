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
        /// <summary>
        ///     Mobil satışta ürün bulmaya, Stok takibinde barkod ile kontrol etmeye, ürün fiyatı sorgulamalarında kullanmak için eklendi.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///     Ürünün Tl cinsinden satış fiyatı
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        ///     Ürünün mevcut stok adedi
        /// </summary>
        public int CriticalLevel { get; set; }
        /// <summary>
        ///     ürünün minumum kritik stok seviyesi belirlenen seviyenin altına düştüğünde uyarı vermek için eklendi.Raporda kullanılacak.
        /// </summary>

        public int CategoryId { get; set; }
        /// <summary>
        ///     Ürünün bağlı olduğu kategoriye ait Foreign Key.
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        ///     EF İlişkisi için tanımlandı. Bir ürün bir kategoriye aittir.
        /// </summary>
        public int SupplierId { get; set; }
        /// <summary>
        ///     Ürünün bağlı olduğu tedarikçiye ait Foreign Key.
        /// </summary>
        public Supplier Supplier { get; set; }
        /// <summary>
        ///     EF İlişkisi için tanımlandı. Bir ürün bir tedarikçiye aittir.
        /// </summary>
        public ICollection<SaleItem> SaleItems { get; set; }
        /// <summary>
        ///     Bir ürün birden çok satış kaleminde (SaleItem) yer alabilir. One to many ilişki. Burada kullanılan koleksiyon, ürünün dahil olduğu satış kalemlerini tutar, bu sayede hangi müşteriye, hangi çalışandan ve hangi mağazadan satıldığını takip edebiliriz.
        /// </summary>
        public ICollection<StockMovement> StockMovements { get; set; }
        /// <summary>
        ///     Bir ürün birden çok stok hareketinde (StockMovement) yer alabilir. One to many ilişki. Stok giriş çıkış işlemlerini takip etmek için kullanılır.
        /// </summary>
    }

}
