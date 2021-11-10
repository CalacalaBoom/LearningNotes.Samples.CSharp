using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = (decimal)1112.82;
            decimal num2 = (decimal)9270.81;
            decimal num3 = num2 - num1;
            Console.WriteLine(num3.ToString());
            Console.ReadLine();
        }
    }
}
