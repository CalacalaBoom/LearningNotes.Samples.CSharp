using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            char b = '8';
            char c = 'L';
            char d = '.';
            char e = '|';
            char f = ' ';
            Console.WriteLine("a是否是字母："+char.IsLetter(a));
            Console.WriteLine("b是否是数字："+char.IsDigit(b));
            Console.WriteLine("c是否是字母或数字："+char.IsLetterOrDigit(c));
            Console.WriteLine("a是否是是小写字母："+char.IsLower(a));
            Console.WriteLine("c是否是大写字母"+char.IsUpper(c));
            Console.WriteLine("d是否是标点符号"+char.IsPunctuation(d));
            Console.WriteLine("e是否是分隔符" + char.IsSeparator(e));
            Console.WriteLine("f是否是空白" + char.IsWhiteSpace(f));
            Console.ReadLine();
        }

    }
}
