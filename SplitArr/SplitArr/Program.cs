using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { {1,2,3},{4,5,6} };
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                        arr1[j] = arr[i, j];
                    else
                        arr2[j] = arr[i, j];
                }
            }
            Console.Write("数组一：");
            foreach(int n in arr1)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            Console.Write("数组二：");
            foreach (int n in arr2)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
