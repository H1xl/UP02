using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        // Перевод часов + минут в секунды
        public int TimeInSeconds(int a, int b)
        {
            return a * 3600 + b * 60 - 1;
        }

        // Перевод секунд в часы
        public int TimeSecondsToHours(int a)
        {
            return a / 3600;
        }
    }
}
