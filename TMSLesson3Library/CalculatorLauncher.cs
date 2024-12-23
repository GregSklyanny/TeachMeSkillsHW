using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TMSLesson3Library
{
    public class CalculatorLauncher
    {
        private IMathOperator _mathOperator;
        private bool flag = true;
        
        public void SetOperator(IMathOperator mathOperator) => _mathOperator = mathOperator;
        public void Launch()
        {
            while (flag)
            {
                float a = 0 , b = 0;

                try
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите число");
                    Console.ForegroundColor = ConsoleColor.White;
                    a = InputValidator.FloatValidator(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("+ - сложение");
                    Console.WriteLine("- - вычитание");
                    Console.WriteLine("/ - деление");
                    Console.WriteLine("* - умножение");
                    Console.WriteLine("% - процент от числа");
                    Console.WriteLine("sqrt - квадратный корень числа");
                    Console.WriteLine("Введите знак действия: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string action = InputValidator.ActionValidator(Console.ReadLine());
                    
                    if(action != "sqrt")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Введите второе число");
                        Console.ForegroundColor = ConsoleColor.White;
                        b = InputValidator.FloatValidator(Console.ReadLine());
                        InputValidator.ExpressionValidator(a, b, action);
                    }
                    else
                    {
                        InputValidator.ExpressionValidator(a, action);
                    }
                    

                    switch (action)
                    {
                        case "+":
                            SetOperator(new SumOperator(a, b));
                            break;
                        case "-":
                            SetOperator(new SubtractionOperator(a, b));
                            break;
                        case "*":
                            SetOperator(new MultiplicationOperator(a, b));
                            break;

                        case "/":
                            SetOperator(new DivisionOperator(a, b));
                            break;
                        case "%":
                            SetOperator(new PercentageOperator(a, b));
                            break;
                        case "sqrt":
                            SetOperator(new SqrtOperator(a));
                            break;
                    }
                    string answer = _mathOperator.Solve();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(answer);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                flag = IsNeedRestart();
            }
        }
        public static bool IsNeedRestart()
        {
            string str = string.Empty;
            ConsoleKey consoleKey;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Начать заново? y - начать заново, n - выйти из программы");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.Y) return true;
                if (consoleKey == ConsoleKey.N) return false;
            }
            return false;
        }
    }
}
