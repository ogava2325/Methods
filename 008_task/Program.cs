//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу, в которой создайте метод, который выведет все числа от 1 до N. N – число
//которое пользователь вводит с клавиатуры. (Использовать рекурсию)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_task
{
    internal class Program
    {
        static void Recurssion(int N)
        {
            N--;
            if (N != 0) Recurssion(N);
            Console.Write(++N + " ");

        }
        static void Main(string[] args)
        {
            Recurssion(8);
        }
    }
}
