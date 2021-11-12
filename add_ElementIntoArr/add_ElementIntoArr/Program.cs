using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_ElementIntoArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {0,1,2,3,4,6,7,8,9};
            Console.WriteLine("原数组元素");
            foreach (int n in arr)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            arr=AddArr(arr,4,5);
            Console.WriteLine("插入元素之后的数组元素：");
            foreach (int n in arr)
            {
                Console.Write(n+" ");
            }
            Console.ReadLine();
            
        }
        static int[] AddArr(int[] arrB,int index,int value)
        {
            if (index >= arrB.Length)
            {
                index = arrB.Length - 1;
            }
            int[] arrTem = new int[arrB.Length+1];
            for (int i = 0; i < arrTem.Length; i++)
            {
                if (index > 0)
                {
                    if (i < (index + 1))
                    {
                        arrTem[i] = arrB[i];
                    }
                    else if (i == index + 1)
                    {
                        arrTem[i] = value;
                    }
                    else
                    {
                        arrTem[i] = arrB[i - 1];
                    }
                }
                else if (index == 0)
                {
                    if (i == 0)
                    {
                        arrTem[i] = value;
                    }
                    else
                    {
                        arrTem[i] = arrB[i - 1];
                    }
                }
                else
                {
                    Console.WriteLine("插入位置错误");
                }
            }

            return arrTem;
        }
    }
}
