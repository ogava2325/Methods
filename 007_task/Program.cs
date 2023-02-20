using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_task
{
    internal class Program
    {
        static void Method()
        {
            Console.WriteLine("Введіть довжину сторні прямокутника");
            float length = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine($"Площа прямокутника = {length * width} см^2");
            Console.WriteLine($"Периметр прямокутника = {(length + width) * 2} см");
        }
        static void Main(string[] args)
        {
            Method();
        }
    }
}
