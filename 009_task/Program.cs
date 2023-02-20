//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу, которая будет вычислять сумму цифр числа N. Число N пользователь
//должен вводить с клавиатуры. При решении этой задачи нельзя использовать строки, списки,
//массивы (ну и циклы, разумеется). (Использовать рекурсию)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_task
{
    internal class Program
    {
        static int Recurssion(int N)
        {
            while(N>=1) return N%10 + Recurssion(N/10);
            return 0;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Recurssion(N));
        }
    }
}
