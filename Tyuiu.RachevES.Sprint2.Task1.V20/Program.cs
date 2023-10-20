using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint2.Task1.V20.Lib;

namespace Tyuiu.RachevES.Sprint2.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                           *");
            Console.WriteLine("* Тема: Логические Операции                                                           *");
            Console.WriteLine("* Задание #1                                                                          *");
            Console.WriteLine("* Вариант #13                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                     *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)          *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций              *");
            Console.WriteLine("* не должна нарушаться), а также арифметических выражений, которая вернет логическую  *");
            Console.WriteLine("* последовательность(массив): (False, False, False, True, True, True),                *");
            Console.WriteLine("* при a = 242, b = 155, c = 456, d = 17                                               *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("  a = 242, b = 155, c = 456, d = 17                                                   *");

            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Число а - : " + a);
            Console.WriteLine("Число b - : " + b);
            Console.WriteLine("Число c - : " + c);
            Console.WriteLine("Число d - : " + d);

            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");

            for (int i = 0; i < 6; i++)

            Console.WriteLine(res[i]);
            Console.ReadLine();
        }
    }
}
