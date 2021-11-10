 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptAndSegmentation_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.截取字符串Substring()方法，参数为起始位置索引（从0开始）和长度\n");
            string str1 = "小公鸡点到谁我就选谁";
            string str2 = str1.Substring(2, 4);
            Console.WriteLine("“小公鸡点到谁我就选谁”从索引2向后截取4个字符\n"+str2+"\n\n");
            Console.WriteLine("2.分割字符串Split()方法用于分割字符串，返回包含所有分割字符串的数组对象,参数是分割符数组\n");
            string strA = "千里送人头，闪现抢五杀";
            char[] sep = { '，' };
            string[] spl = new string[100];
            spl = strA.Split(sep);
            Console.WriteLine("“千里送人头，闪现抢五杀”以','为分割符分割字符串：");
            for (int i = 0; i < spl.Length; i++)
            {
                Console.WriteLine("item{0}:{1}", i, spl[i]);
            }
            Console.ReadLine();

        }
    }
}
