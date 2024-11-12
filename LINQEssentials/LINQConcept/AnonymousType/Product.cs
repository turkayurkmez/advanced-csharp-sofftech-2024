using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }

    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new(){ Id=1, Name="P1", Description="P1 Açıklama", Price=5, Color="Black"},
                new(){ Id=2, Name="P2", Description="P2 Açıklama", Price=15, Color="Orange"},
                new(){ Id=3, Name="P3", Description="P3 Açıklama", Price=25, Color="Red"},
                new(){ Id=4, Name="P4", Description="P4 Açıklama", Price=35, Color="Pink"},

            };
        }
    }

    public class SpecialProductInfo
    {
        public string UrunAdi { get; set; }
        public string Renk { get; set; }
    }
}

