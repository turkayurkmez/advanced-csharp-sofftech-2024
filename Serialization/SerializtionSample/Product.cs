using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializtionSample
{
   
    public class Product
    {
        public int Id { get; set; }
        public NameDetail Name { get; set; } = new NameDetail ();
        public string Description { get; set; }
        public decimal Price { get; set; }



    }

    public record NameDetail
    {
        public string Turkish { get; set; }
        public string English { get; set; }
    }


    public class ProductList
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void Add(Product product)=>Products.Add(product);
        public void Clear()=> Products.Clear();
         
    }

}
