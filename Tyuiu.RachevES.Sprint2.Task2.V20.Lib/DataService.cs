using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RachevES.Sprint2.Task2.V20.Lib
{
    public class DataService : ISprint2Task2V20
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            int[,] coord = new int[15, 15]                         //коорд
            {//коорд:X1  2  3  4  5  6  7  8  9  10 11 12 13 14 15     Y              
                     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //1
                     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, //2
                     {0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, //3
                     {0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, //4
                     {0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, //5
                     {0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0 }, //6
                     {0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0 }, //7
                     {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 }, //8
                     {0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 }, //9
                     {0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 },//10
                     {0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0 },//11
                     {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 },//12
                     {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },//13
                     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },//14
                     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },//15
            };

            if (coord[x, y] == 1)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
