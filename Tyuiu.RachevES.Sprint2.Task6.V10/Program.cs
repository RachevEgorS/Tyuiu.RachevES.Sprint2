using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint2.Task6.V10.Lib;

namespace Tyuiu.RachevES.Sprint2.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                           *");
            Console.WriteLine("* Тема: Получение результата из switch                                                *");
            Console.WriteLine("* Задание #6                                                                          *");
            Console.WriteLine("* Вариант #10                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch    *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                                *");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*                                                                                     *");
           
            Console.WriteLine("Год -");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Месяц -");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("День -");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfPreviousDay(year, month, date);
            Console.WriteLine("Предыдущая дата :" + res);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
