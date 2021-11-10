using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1;

namespace NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            A oa = new A();
            oa.Myle();
        }
    }
}
namespace N1
{
    class A
    {
        public void Myle()
        {
            Console.WriteLine("这里是命名空间N1.A.Myle()方法");
            Console.Read();
        }
    }
}
