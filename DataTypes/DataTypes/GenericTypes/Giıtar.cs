using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class Gitar
    {
       public virtual void Cal() => Console.WriteLine("Gitar çalıyor");
    }

    public class ElektroGitar: Gitar
    {
        public override void Cal()
        {
            Console.WriteLine("Elektro....");
        }
    }
}
