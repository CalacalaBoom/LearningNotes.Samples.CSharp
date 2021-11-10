 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffofVTandRT
{
    class Program
    {
        static void Main(string[] args)
        {
            ReferenceAndValue.Demonstration();
            Console.ReadLine();
        }
        public class stamp
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public static class ReferenceAndValue
        {
            public static void Demonstration()
            {
                stamp Stamp_1 = new stamp { Name = "Premiere", Age = 25 };
                stamp Stamp_2 = new stamp { Name = "Again", Age = 47 };
                int age = Stamp_1.Age;
                Stamp_1.Age = 22;//在改变了Stamp_1的Age值后Age没有跟着变化
                stamp guru = Stamp_2;
                Stamp_2.Name = "Again Amend";//而在改变了Stamp_2的Name值后，guru的Name值却跟着变化
                Console.WriteLine("Stamp_1's age:"+Stamp_1.Age);
                Console.WriteLine("age's Value:"+age);
                Console.WriteLine("Stamp_2's Name:" + Stamp_2.Name);
                Console.WriteLine("guru's Name:" + guru.Name);
                   
            }
        }
    }



















}
