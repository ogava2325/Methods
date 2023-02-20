using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006__task
{
    internal class Program
    {
        static void Method(ref int a, ref int b, ref int c)
        {
            a *= 10;
            b *= 10;
            c *= 10;
        }
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            Method(ref a, ref b, ref c);
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
}
