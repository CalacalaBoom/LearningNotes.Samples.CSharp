using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] arr = new string[9][];
            for (int n=0;n<9;n++)
            {
                arr[n] = new string[n+1];
                for (int i = 0; i < arr[n].Length; i++)
                {
                    arr[n][i] = (i + 1) + "×" + (n + 1) + "=" + (n + 1) * (i + 1);
                    Console.Write(arr[n][i]+"  ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
