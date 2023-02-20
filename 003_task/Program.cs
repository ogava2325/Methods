using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_task
{
    internal class Program
    {
        static int Method(int year)
        {
            return DateTime.Now.Year - year - 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Method(2004));
        }
    }
}
