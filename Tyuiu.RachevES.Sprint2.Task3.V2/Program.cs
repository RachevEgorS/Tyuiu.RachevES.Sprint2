using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint2.Task3.V2.Lib;

namespace Tyuiu.RachevES.Sprint2.Task3.V2
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
            Console.WriteLine("* Задание #3                                                                          *");
            Console.WriteLine("* Вариант #2                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y                  *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит значение       *");
            Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков послезапятой*");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");

            Console.WriteLine("Введите х : ");
            double x = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x);
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                         *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("Y =" + res);
            Console.ReadLine();
        } 


            
        
    }
}
