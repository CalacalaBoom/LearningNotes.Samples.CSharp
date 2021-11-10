using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.拼接str1(相信自己)和str2(永不放弃)：\n");
            string str1 = "相信自己";
            string str2 = "永不放弃";
            string newstr = String.Format("{0},{1}!!!", str1, str2);//使用占位符
            Console.WriteLine(newstr+"\n\n");
            Console.WriteLine("2.格式化输出当前时间：\n");
            DateTime dt = DateTime.Now;
            String s_d = string.Format("{0:d}", dt);
            String s_D = string.Format("{0:D}", dt);
            String s_t = string.Format("{0:t}", dt);
            String s_T = string.Format("{0:T}", dt);
            String s_f = string.Format("{0:f}", dt);
            String s_F = string.Format("{0:F}", dt);
            String s_g = string.Format("{0:g}", dt);
            String s_G = string.Format("{0:G}", dt);
            String s_m = string.Format("{0:m}", dt);
            String s_y = string.Format("{0:y}", dt);
            Console.WriteLine("格式规范：输出格式");
            Console.WriteLine("   d    ：" + s_d);
            Console.WriteLine("   D    ：" + s_D);
            Console.WriteLine("   t    ：" + s_t);
            Console.WriteLine("   T    ：" + s_T);
            Console.WriteLine("   f    ：" + s_f);
            Console.WriteLine("   F    ：" + s_F);
            Console.WriteLine("   g    ：" + s_g);
            Console.WriteLine("   G    ：" + s_G);
            Console.WriteLine("   m    ：" + s_m);
            Console.WriteLine("   y    ：" + s_y);
            Console.ReadLine();
        }
    }
}
