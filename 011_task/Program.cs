//Используя Visual Studio, создайте проект по шаблону Console Application.
//Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли
//клиент кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн.
//Клиент должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может
//двумя платежами по 300 и 400 грн. Закрыть весь долг
//Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную
//экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма
//задолженности, сумма переплаты, сообщение об отсутствии долга).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_task
{
    internal class Program
    {
        static int dept = 700;
        static void Method(int money)
        {
            if(money < 100) Console.WriteLine("Недостатня сума платежу");
            else 
            {
                dept -= money;
                switch (dept)
                { 
                    case int a when (a > 0):
                        Console.WriteLine($"Ви повинні заплатити {dept} UAH");
                        break;
                    case int a when (a < 0):
                        Console.WriteLine($"Ви погасили борг та переплатили {Math.Abs(dept)} UAH");
                        break;  
                    default: Console.WriteLine("Ви погасили борг"); break;
                }
            }

        }
        static void Main(string[] args)
        {
            Method(123);
            Method(1);
        }
    }
}
