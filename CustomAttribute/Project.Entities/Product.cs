using Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    [DeveloperInfo("Türkay Ürkmez", CreatedDate = "13.11.2024", CodeDescription ="Bu veri modeli, db'deki Ürün tablosuna yöneliktir ")]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DeveloperInfo("Türkay Ürkmez", CodeDescription ="Fiyat bilgisinin double olmasına karat verildi")]
        [DeveloperInfo("Cemile Fedakar", CodeDescription ="fiyat alanının veri tipi decimal olarak değiştirildi")]
        public decimal Price { get; private set; }

        [DeveloperInfo("Çağlar Mutlu", CodeDescription ="DDD esaslarına uygun fiyat güncelleme amaçlı yazıldı")]
        public void ChangePrice(decimal price) => Price = price;
    }
}
