using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeminar.Lesson2
{
    internal class HomeWorkLesson2
    {
        public string SecondNum(int num)
        {
            if (num > 1) return $"{num.ToString()[2]} вторая цифра";
            else return "Эй!Тут всего 1 цифра";
        }
        public string TNum(int num)
        {
            if (num > 2) return $"{num.ToString()[3]} третья цифра";
            else return "Эй!Тут не 3 цифры";
        }
        public string isWeekend(int num)
        {
            if (num == 6 || num ==7) 
            {
                return "Можно пить пиво!";
            }
            else return "Эй,Работай!";
        }

    }
}
