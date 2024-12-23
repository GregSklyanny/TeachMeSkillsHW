using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TMSLesson3Library
{
    public class InputValidator
    {
        private static List<string> validActions = new List<string>()
            {
                "+",
                "-",
                "/",
                "*",
                "%",
                "sqrt"
            };
        public static float FloatValidator(string a)
        {
            float output;
            
            if(float.TryParse(a.Trim().Replace('.',','), out output))
            {
                return output;
            }
            throw new ArgumentException("Это не число");
        }
        public static string ActionValidator(string a)
        {
            string output = a.Trim().ToLower();

            if (validActions.Contains(output))
            {
                return output;
            }

            throw new ArgumentException("Действие введено неверно!");
        }

        // Блок валидации выражения, 2 перегрузки - для унарных и бинарных операций
        public static void ExpressionValidator(float a, float b, string action)
        {
            switch (action)
            {
                case "%":
                    if (a < 0 || b < 0) throw new ArgumentException("Отрицательные числа!");
                    if (b == 0) throw new ArgumentException("Второе число = 0! Деление на ноль!");
                    break;
                case "/":
                    if(b == 0) throw new ArgumentException("Деление на ноль!");
                    break;
            }
        }

        public static void ExpressionValidator(float a, string action)
        {
            switch (action)
            {
                case "sqrt":
                    if (a < 0) throw new ArgumentException("Отрицательное число под корнем, зачем вам комплексное число? ;)");
                    break;
           }
        }
    }
}
