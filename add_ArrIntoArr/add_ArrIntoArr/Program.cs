using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_ArrIntoArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {0,1,2,3,8,9};
            int[] addarr = new int[] {4,5,6,7};
            Console.WriteLine("插入之前的数组元素：");
            foreach (int n in arr)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            Console.WriteLine("要插入的数组元素：");
            foreach (int n in addarr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            int[] arrtem = Addarr(arr,addarr,3);
            Console.WriteLine("插入之后的数组元素：");
            foreach (int n in arrtem)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
        static int[] Addarr(int[] arr,int[] addarr,int index)
        {
            int[] arrtem = new int[arr.Length+addarr.Length];
            if (index >= (arr.Length))
            {
                index = arr.Length - 1;
            }
            for (int i = 0; i < arrtem.Length; i++)
            {
                if (index >= 0)
                {
                    if (i < (index + 1))
                    {
                        arrtem[i] = arr[i];
                    }
                    else if (i == (index + 1))
                    {
                        for (int j = 0; j < addarr.Length; j++)
                        {
                            arrtem[i + j] = addarr[j];
                        }
                        i = i + (addarr.Length - 1);
                    }
                    else
                    {
                        arrtem[i] = arr[i - addarr.Length];
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < arr.Length; j++)
                        {
                            arrtem[i + j] = addarr[j];
                        }
                        i = i + (addarr.Length - 1);
                    }
                    else
                    {
                        arrtem[i] = arr[i - addarr.Length];
                    }
                }
            }
            return arrtem;
        }
    }
}
