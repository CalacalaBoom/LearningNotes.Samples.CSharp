using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteArr_ChangeLen
{
    class Program
    {
        static string[] DeleteArr(string[] arr, int index, int Len)
        {
            if (Len <= 0)
            {
                return arr;
            }
            if (index == 0 && Len >= arr.Length)
            {
                Len = arr.Length;
            }
            else if ((index+Len)>=arr.Length)
            {
                Len = arr.Length;
            }
            string[] temarr = new string[arr.Length-Len];
            for (int i = 0; i < temarr.Length; i++)
            {
                if (i >= index)
                {
                    temarr[i] = arr[i + Len];
                }
                else
                {
                    temarr[i] = arr[i];
                }
            }
            return temarr;
        }
        static void Main(string[] args)
        {
            String[] arr = new string[] {"i","am","seting","here","in","a","boring","room"};
            Console.Write("原数组：");
            foreach (string n in arr)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            String[] arrTem = DeleteArr(arr,0,1);
            Console.Write("删除后的数组：");
            foreach (string n in arrTem)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}
