using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_task
{
    internal class Program
    {
        static int Summarise(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static float Divide(float a, int b)
        {
            if (b != 0) return a / b;
            else return int.MinValue;
        }
        static int Multiply(int a, int b)
        { return a * b; }
        static void Main(string[] args)
        {
            char sign;
            int a, b;
            Console.WriteLine("Введіть два числа");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть знак операції");
            sign = char.Parse(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    Console.WriteLine($"{a} {sign} {b} = {Summarise(a, b)}");
                    break;
                case '-':
                    Console.WriteLine($"{a} {sign} {b} = {Subtract(a, b)}");
                    break;
                case '*':
                    Console.WriteLine($"{a} {sign} {b} = {Multiply(a, b)}");
                    break;
                case '/':
                    Console.WriteLine($"{a} {sign} {b} = {Divide(a, b)}");
                    break;
                default: Console.WriteLine("Невірні дані"); break;
            }
        }
    }
}
