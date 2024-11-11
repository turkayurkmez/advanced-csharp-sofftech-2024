using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.Repository
{

    /*
     * Dilediğiniz kadar generic type tanımlayabilirsiniz. Eğer her birini sınırlamanız gerekiyorsa; her biri için where ifadesini kullanmalısınız.
     */
    public interface IRepository<T> where T : class, IEntity, new()
                                      
    {
        T Find(int id);
        IList<T> GetAll();
        void Create(T entity);

    }

    public class ProductRepository : IRepository<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }

   

}
