using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOfStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Append()  2.AppendFormat()  3.Insert()  4.Remove()  5.Replace()  0.Exit");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        MofSB.A();
                        break;
                    case "2":
                        MofSB.AF();
                        break;
                    case "3":
                        MofSB.I();
                        break;
                    case "4":
                        MofSB.Rm();
                        break;
                    case "5":
                        MofSB.Rp();
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        public static class MofSB
        {
            public static void A()
            {
                Console.WriteLine("Append()用于将文本或字符串追加到对象的末尾");
                StringBuilder StrBui1 = new StringBuilder("勇士",100);
                StrBui1.Append("VS骑士");
                Console.WriteLine(StrBui1);
            }
            public static void AF()
            {
                Console.WriteLine("AppendFormat()自定义变量的值并把其追加到对象的末尾");
                StringBuilder StrBui = new StringBuilder("白菜价格：",100);
                StrBui.AppendFormat("{0:C}", 3.5);
                Console.WriteLine(StrBui);
            }
            public static void I()
            {
                Console.WriteLine("在对象的指定位置插入字符串");
                StringBuilder StrBui = new StringBuilder("勇士VS骑士",100);
                StrBui.Insert(0,"PK:");
                Console.WriteLine(StrBui);
            }
            public static void Rm()
            {
                Console.WriteLine("Remove()方法删除指定位置开始指定数量的字符");
                StringBuilder StrBui = new StringBuilder("EDG牛逼！！！");
                StrBui.Remove(5,StrBui.Length-5);
                Console.WriteLine(StrBui);
            }
            public static void Rp()
            {
                Console.WriteLine("Replace()方法可以用另一个指定的字符来替换对象内的字符");
                StringBuilder StrBui = new StringBuilder("勇士VS骑士");
                StrBui.Replace("骑士","湖人");
                Console.WriteLine(StrBui);
            }
        }
    }
}
