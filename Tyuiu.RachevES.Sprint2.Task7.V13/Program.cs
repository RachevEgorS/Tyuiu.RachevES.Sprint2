﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint2.Task7.V13.Lib;

namespace Tyuiu.RachevES.Sprint2.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                           *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                             *");
            Console.WriteLine("* Задание #7                                                                          *");
            Console.WriteLine("* Вариант #13                                                                         *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные                       *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка                             *");
            Console.WriteLine("* с координатами X,Y в заштрихованной области.                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");

            Console.WriteLine("Введите Х -");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Y -");
            double y = double.Parse(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка закрашена!");
            }
            else
            {
                Console.WriteLine("Точка не закрашена!");
            }

            Console.ReadKey();
        }
    }
}
