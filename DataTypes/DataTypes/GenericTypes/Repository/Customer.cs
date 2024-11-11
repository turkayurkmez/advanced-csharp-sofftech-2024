using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.Repository
{

    public interface IEntity
    {

    }

    public abstract class EntityBase : IEntity
    {

    }
    public class Customer :EntityBase
    {
        public int Id { get; set; }
        public string    Name { get; set; }
        public string Address { get; set; }

    }

    public class Product: EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
