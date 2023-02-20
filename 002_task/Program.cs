using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_task
{
    internal class Program
    {
        static float Method(float a, float b)
        {
            if (a == b) { Console.WriteLine("Числа рівні"); return 0.0f; }
            else
            {
                float c = a;
                c = (a > b) ? a : b;
                return c;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Method(4, 4.1f));
        }
    }
}
