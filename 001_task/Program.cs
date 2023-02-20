//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу в которой создайте метод, который принимает в качестве параметров три
//целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_task
{
    internal class Program
    {
        static void Average(float a, int b,int c)
        {
            Console.WriteLine($"Середнє арифметичне чисел {a},{b} і {c} = {(a + b + c) / 3}");
        }
        static void Main(string[] args)
        {
            Average(2, 3, 2);
        }
    }
}
