using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Library
{
    public class Utils
    {
        public string OddOrEvenAnalyzer(string str)
        {
            int number;
            if (int.TryParse(str, out number))
            {
                return number % 2 == 0 ? $"Число {number} четное" : $"Число {number} нечетное";
            }

            return "Это не целое число!";
        }
    }
}
