using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Insert()  2.PadLeft()/PadRight()  3.Remove()  4.Copy()/CopyTo()  5.Replace()  0.Exit");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        EOfS.Insert();
                        break;
                    case "2":
                        EOfS.Pad();
                        break;
                    case "3":
                        EOfS.Delete();
                        break;
                    case "4":
                        EOfS.Copy();
                        break;
                    case "5":
                        EOfS.Replace();
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        public static class EOfS
        {
            public static void Insert()
            {
                Console.WriteLine("Insert()方法提供向索引位置（参数1）插入字符串（参数2）\n向“梦想还是要有的，万一实现了呢！”的开头插入“马云说”，结尾插入“你信吗”");
                string str1 = "梦想还是要有的，万一实现了呢！";
                string str2 = str1.Insert(0, "马云说：");
                string str3 = str2.Insert(19, "你信吗");
                Console.WriteLine(str3);
            }
            public static void Pad()
            {
                Console.WriteLine("String类提供了PadLeft()和PadRight()两种方法，分别用于字符串的左边和右边进行字符串填充，第一个参数指定填充后的字符串长度，第二个参数指定需要填充的字符，省略则填充给空格");
                String str1 = "T-T";
                String str2 = str1.PadLeft(4,'(');
                str2 = str2.PadRight(5,')');
                Console.WriteLine("填充之前：" + str1);
                Console.WriteLine("填充之后：" + str2);
            }
            public static void Delete()
            {
                Console.WriteLine("Remove(参数1)方法用来删除从参数1到最后位置的所有字符；Remove(参数1,参数2)用来删除从参数1开始长度为参数2的字符");
                Console.WriteLine("1.Remove(参数1)用法：");
                String str1 = "EDG牛逼";
                String strA = str1.Remove(3);
                Console.WriteLine(strA);
                Console.WriteLine("2.Remove(参数1,参数2)用法");
                String strB = str1.Remove(0,3);
                Console.WriteLine(strB);
            }
            public static void Copy()
            {
                Console.WriteLine("String类提供了Copy()和CopyTo()两种方法,Copy()创建一个与指定字符串具有相同值的字符串的实例，CopyTo()可以将字符串的某一部分复制到另一个数组中");
                Console.WriteLine("1.Copy()用法");
                string str1 = "EDG牛逼";
                string str2 = String.Copy(str1);
                Console.WriteLine(str2);
                Console.WriteLine("2.CopyTo()用法,CopyTo()的语法是这样的CopyTo([需要复制的字符的起始位置],[目标字符数组],[指定目标字符数组的开始存放位置],[要复制的字符个数])");
                char[] ch = new char[100];
                str1.CopyTo(0,ch,0,3);
                Console.WriteLine(ch);
            }
            public static void Replace()
            {
                Console.WriteLine("Replace()方法用于把字符串中的某个字符或字符串替换成其他字符或字符串");
                Console.WriteLine("1.替换字符串中指定的字符");
                string str1 = "one world,one dream";
                string str2 = str1.Replace(',', '*');
                Console.WriteLine(str2);
                Console.WriteLine("2.替换字符串中指定字符串");
                string str3 = str1.Replace("one world","One World");
                Console.WriteLine(str3);
            }
        }
    }
}
