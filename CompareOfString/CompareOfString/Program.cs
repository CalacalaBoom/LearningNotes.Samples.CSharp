using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compare():1  Compare To():2  Equals():3  Exit:0");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        CofS.C();
                        break;
                    case "2":
                        CofS.CT();
                        break;
                    case "3":
                        CofS.E();
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        public static class CofS
        {
            public static void C()
            {
                Console.WriteLine("Compare()方法用来比较两个字符串是否相等，三个参数的重载表示忽略大小写的差别");
                string str1 = "AsDfgHJkl";
                string str2 = "asdfghjkl";
                Console.WriteLine("String.Compare(str1,str2):"+String.Compare(str1,str2));
                Console.WriteLine("String.Compare(str1,str2,true):" + String.Compare(str1,str2,true));
                Console.WriteLine("String.Compare(str1,str1):" + String.Compare(str1, str1));
            }
            public static void CT()
            {
                Console.WriteLine("CompareTo()方法以实例化对象本身与指定字符串比较是否相等");
                string str1 = "支付宝";
                string str2 = "微信";
                Console.WriteLine(str1.CompareTo(str2));
            }
            public static void E()
            {
                Console.WriteLine("Equals()方法比较两个字符串是否相同，返回布尔值。有静态和以对象本身两种调用方法");
                string str1 = "支付宝";
                string str2 = "微信";
                Console.WriteLine("str1.Equals(str2):"+str1.Equals(str2));
                Console.WriteLine("String.Equals(str1,str2):"+String.Equals(str1,str2));
            }
        }
    }
}
