using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int N0 = 5;
            N += 5;//N=N+5
            Console.WriteLine(N);
            N -= 5;//N=N-5
            Console.WriteLine(N);
            N *= 5;//N=N*5
            Console.WriteLine(N);
            N /= 5;//N=N/5
            Console.WriteLine(N);
            N %= 5;//N=N%5
            Console.WriteLine(N);
            Console.ReadLine();
        }
    }
}
