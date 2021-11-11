using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_StringBuilderAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            long starTime = DateTime.Now.Millisecond;
            for (int i = 0; i < 10000; i++)
            {
                str += i;
            }
            long endTime = DateTime.Now.Millisecond;
            long time = endTime - starTime;
            Console.WriteLine("       String消耗的时间为："+time);
            StringBuilder builder = new StringBuilder("");
            starTime = DateTime.Now.Millisecond;
            for (int j = 0; j < 10000; j++)
            {
                builder.Append(j);
            }
            endTime = DateTime.Now.Millisecond;
            time = endTime - starTime;
            Console.WriteLine("StringBuilder消耗的时间为："+time);
            Console.ReadLine();
        }
    }
}
