using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    /*
     * DDD tasarımlarında Value Object
     * DTO nesneleri 
     * ve bunun dışında karşılaştırma yapılabilecek her yer.....
     */
    public record Product(int id, string name, decimal price);
    //public int Id { get; set; }
    //public string Name { get; set; }
    //public decimal Price { get; set; }  
    public record Address(string City, string Street, string Country);

}
