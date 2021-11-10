using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("is运算符：1  条件运算符：2  new运算符：3  typeof运算符：4  Exit:0");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        SpacialOperator.Is_Opre();
                        break;
                    case "2":
                        SpacialOperator.Con_Opre();
                        break;
                    case "3":
                        SpacialOperator.New_Opre();
                        break;
                    case "4":
                        SpacialOperator.Typeof_Opre();
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
            

        }
        public static class SpacialOperator
        {
            public static void Is_Opre()
            {
                int i = 10;
                bool result = i is int;
                Console.WriteLine("i是整形");
            }
            public static void Con_Opre()
            {
                Console.WriteLine("请输入一个年份：");
                String str = Console.ReadLine();
                int year = Convert.ToInt32(str);
                bool isLeapyear = ((year%400)==0)||(((year%4)==0)&&((year%100)!=0));
                string yesorno = isLeapyear ? "是" : "不是";//"条件式?值1:值2",当条件式为true,输出值1，反之输出值2
                Console.WriteLine(year+yesorno+"闰年");
            }
            public static void New_Opre()
            {
                string[] phone = new string[5];
                phone[0] = "华为";
                phone[1] = "小米";
                phone[2] = "OPPO";
                phone[3] = "VIVO";
                phone[4] = "一加";
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(phone[i]);
                }
            }
            public static void Typeof_Opre()
            {
                Type type = typeof(int);
                Console.WriteLine(type);
            }

        }
    }
}
