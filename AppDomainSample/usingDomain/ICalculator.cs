using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDomain
{
    public interface ICalculator 
    {
        int Add(int a, int b);
    }

    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($"Hesaplama işlemi, {AppDomain.CurrentDomain.FriendlyName}  domain'i tarafından yapılıyor");
            return a + b;
        }

    }
}
