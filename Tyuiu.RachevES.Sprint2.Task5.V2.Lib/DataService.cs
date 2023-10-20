using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RachevES.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string res;
            switch (value)
            {
                case 1: //01.01
                    res = "Зима";
                    break;
                case 2: //01.02
                    res = "Зима";
                    break;
                case 3: //01.03
                    res = "Весна";
                    break;
                case 4: //01.04
                    res = "Весна";
                    break;
                case 5: //01.05
                    res = "Весна";
                    break;
                case 6: //01.06
                    res = "Лето";
                    break;
                case 7: //01.07
                    res = "Лето";
                    break;
                case 8: //01.08
                    res = "Лето";
                    break;
                case 9: //01.09
                    res = "Осень";
                    break;
                case 10: //01.10
                    res = "Осень";
                    break;
                case 11: //01.11
                    res = "Осень";
                    break;
                case 12: //01.12
                    res = "Зима";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");
            }
            return res;
        }
    }
}
