using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenceType
{
    class Program
    {
        class C
        {
            public int Value = 0;
        }
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = v1;
            v2 = 927;
            C c1 = new C();
            C c2 = c1;
            c2.Value = 112;
            Console.WriteLine("Values:{0},{1}", v1, v2);
            Console.WriteLine("Refs:{0},{1}", c1.Value, c2.Value);
            Console.ReadLine();
        }
    }
}
