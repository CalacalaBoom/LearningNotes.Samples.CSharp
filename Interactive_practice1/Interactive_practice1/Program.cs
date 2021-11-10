using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 经理有3个女儿，她们的年龄之和是13岁，年龄的乘积等于经理的年龄。有位员工知道经理的年龄，但是不能确定他
 的3个女儿都是多大，这是，经理和他说，我只有一个女儿的年龄超过5岁，于是那位员工就知道了经理3个女儿的年
 龄，那么经理的3个女儿都分别是多大？
     */
namespace Interactive_practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            IS oa= new IS();
            for (int i = 1; i <= 11; i++)
            {
                for (int j = 1; j <= 12 - i; j++)
                {
                    oa.isLarger(i,j,13-i-j);
                }
            }
            Console.Read();
        }
    }
}

class IS
{
    public void isLarger(int num1, int num2, int num3)
    {
        if (num1 >= 5)
        {
            if (num2 >= 5 || num3 >= 5)
            {
                return;
            }
        }
        else if (num2 >= 5 && num3 >= 5)
        {
            return;
        }
        else if(num1*num2*num3>=43 && num1 * num2 * num3 <= 50) //三个孩子都加起来13了，他爸20岁开始生都43岁了
        {
            Console.WriteLine(num1 + " " + num2 + " " + num3 + " " + num1 * num2 * num3);
        }
    }
}