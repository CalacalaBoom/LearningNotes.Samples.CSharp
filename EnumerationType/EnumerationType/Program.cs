using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationType
{
    class Program
    {
        enum MyDate
        {
            Sun=0,
            Mon=1,
            Tue=2,
            Wed=3,
            Thu=4,
            Fri=5,
            Sat=6 
        }
        static void Main(string[] args)
        {
            int k = (int)DateTime.Now.DayOfWeek;
            switch (k)
            {
                case (int)MyDate.Sun:
                    Console.WriteLine("今天是星期天");
                    break;
                case (int)MyDate.Mon:
                    Console.WriteLine("今天是星期一");
                    break;
                case (int)MyDate.Tue:
                    Console.WriteLine("今天是星期二");
                    break;
                case (int)MyDate.Wed:
                    Console.WriteLine("今天是星期三");
                    break;
                case (int)MyDate.Thu:
                    Console.WriteLine("今天是星期四");
                    break;
                case (int)MyDate.Fri:
                    Console.WriteLine("今天是星期五");
                    break;
                case (int)MyDate.Sat:
                    Console.WriteLine("今天是星期六");
                    break;
            }
            Console.ReadLine();
        }
    }
}
