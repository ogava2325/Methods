//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое
//число и определяет количество разрядов данного числа. Пользователь должен иметь
//возможность вводит число с клавиатуры.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_task
{
    internal class Program
    {
        static int Digit(int N)
        {
            int digits = 0;
            while(N/10 >= 1)
            {
                N /= 10;
                digits++;
            }
            return digits;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine($"Розряд числа {N} = {Digit(N)}");
        }
    }
}
