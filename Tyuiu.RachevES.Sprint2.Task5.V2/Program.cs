using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RachevES.Sprint2.Task5.V2.Lib;

namespace Tyuiu.RachevES.Sprint2.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил Рачёв Е. С. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                           *");
            Console.WriteLine("* Тема: Оператор switch                                                               *");
            Console.WriteLine("* Задание #5                                                                          *");
            Console.WriteLine("* Вариант #2                                                                          *");
            Console.WriteLine("* Выполнил: Рачёв Егор Сергеевич |   ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                            *");
            Console.WriteLine("* Написать программу, которая использует оператор switch                              *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.                         *");
            Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков послезапятой*");
            Console.WriteLine("*                                                                                     *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                   *");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("*определите в какую пору года попадает этот месяц(Зима, Лето, Весна, Осень).          *");
            int numMouth = Convert.ToInt32(Console.ReadLine());
            string res;

            if ((numMouth < 1) || (numMouth > 12)) res = "Нет такого месяца!!!!";

            else res = "Сезон года: " + ds.FindMonthSeason(numMouth);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
