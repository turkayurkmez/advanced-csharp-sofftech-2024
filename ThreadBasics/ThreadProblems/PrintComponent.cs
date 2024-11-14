using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadProblems
{
    public class PrintComponent
    {
        private object lockedObject = new object();
        public void PrintNumbers()
        {

            Monitor.Enter(this);
            //lock (lockedObject)
            //{
                for (int i = 0; i < 10; i++)
                {
                    // Console
                    Console.Write(i + "-");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------");
            //}
            Monitor.Exit(this);
        }
    }
}
