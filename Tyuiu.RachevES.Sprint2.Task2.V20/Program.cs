using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint2.Task2.V20.Lib;

namespace Tyuiu.RachevES.Sprint2.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                           *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                                  *");
            Console.WriteLine("* Задание #2                                                                          *");
            Console.WriteLine("* Вариант #20                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые                                    *");
            Console.WriteLine("* значения с клавиатуры и вычисляет находится ли                                      *");
            Console.WriteLine("* точка с координатами X,Y в заштрихованной области.                                  *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            
            Console.WriteLine("Введите х : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите у : ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");

            if (res)
            {
                Console.WriteLine("Точка заштрихована");
            }
            else
            {
                Console.WriteLine("Точка не заштрихована");
            }
            Console.ReadLine();
        }
    }
}
