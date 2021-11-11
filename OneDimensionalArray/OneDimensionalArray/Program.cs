using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] day = new int[] { 31,28,31,30,31,30,31,31,30,31,30,31};
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}月有{1}天",i+1,day[i]);
            }
            Console.ReadLine();
        }
    }
}
