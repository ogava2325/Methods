using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_task
{
    internal class Program
    {
        static void Convertor(string currency, float rate, int cash)
        {
            Console.WriteLine($"Ви маєте {cash / rate} {currency}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введіть символ валюти, в яку хоче перевести гривні, USD - в долари, EUR - в євро: ");
            string currency = Console.ReadLine();
            Console.Write("\nВведіть N, де 1 у.о = N гривень: ");
            float rate = float.Parse(Console.ReadLine());
            Console.Write("\nВведіть суму грошей: ");
            int cash = int.Parse(Console.ReadLine());
            Convertor(currency, rate, cash);
        }
    }
}
