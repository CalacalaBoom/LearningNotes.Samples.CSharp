using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 198136542.1253;
            int y = (int)x;
            Console.WriteLine("x=" + x);
            int z = Convert.ToInt32(x);
            Console.WriteLine("z=" + z);
            Console.Read();
        }
    }
}
