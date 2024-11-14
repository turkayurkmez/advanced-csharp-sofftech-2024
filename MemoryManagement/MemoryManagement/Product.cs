using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductImage { get; set; } = new byte[128];

        public Category Category { get; set; }

    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
