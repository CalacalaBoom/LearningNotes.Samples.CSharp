using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingAndunpacking
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxingandUnboxing.Boxing();
            Console.WriteLine();
            BoxingandUnboxing.Unboxing();
            Console.ReadLine();
        }
        public static class BoxingandUnboxing
        {
            public static void Boxing()
            {
                int i = 2019;
                object obj = i;
                Console.WriteLine("1.1 i的值为{0}，装箱之后的对象为{1}", i, obj);
                i = 297;
                Console.WriteLine("1.2 i的值为{0}，装箱之后的对象为{1}", i, obj);//装箱后改变值变量的值不会影响装箱对象的值
            }
            public static void Unboxing()
            {
                int i = 2019;
                object obj = i;
                Console.WriteLine("2.1 i的值为{0}，装箱之后的对象为{1}", i, obj);
                int j = (int)obj;
                Console.WriteLine("2.2 拆箱对象为{0},值为{1}", obj, j);
            }
        }
    }
}
