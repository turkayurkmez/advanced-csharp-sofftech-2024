using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{

    //out: kovaryant olarak kullanılabilir (base class'a dönüştürülebilir)
    //in: kontravaryant olarak kullanılır (Parametre olarak base ve ondan türeyenler verilebilir.)
    public interface ISimple<in T,out W>
    {
        void Process(T value);
        W GetValue();
        
    }

    public class GitarList : IEnumerable<Gitar>
    {
        public IEnumerator<Gitar> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Simple : ISimple<Gitar, Gitar>
    {
        public Gitar GetValue()
        {
            throw new NotImplementedException();
        }

        public void Process(Gitar value)
        {
            value.Cal();
        }
    }
}
