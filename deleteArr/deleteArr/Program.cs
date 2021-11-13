using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleteArr
{
    class Program
    {
        static void DeleteAArr(String[] arr,int index,int Len)
        {
            if (Len < 0)
            {
                return;
            }
            if (index == 0 && Len >= arr.Length)
            {
                Len = arr.Length;
            }
            else if ((index+Len)>=arr.Length)
            {
                Len = arr.Length - index - 1;
            }
            for (int i = 0; i < arr.Length - index - Len; i++)
            {
                arr[i + index] = arr[index+Len+i];
            }
            for (int j = (arr.Length - 1); j > (arr.Length - Len - 1); j--)
            {
                arr[j] = null;
            }
        }
        static void Main(string[] args)
        {
            String[] arr = new string[] {"dog","cat","pig","bird","duck","flower"};
            Console.Write("原数组：");
            foreach (string n in arr)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();
            DeleteAArr(arr,0,1);
            Console.Write("删除后的数组：");
            foreach (string n in arr)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}
