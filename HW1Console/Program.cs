using System.Reflection;
using HW1Library;


namespace HW1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utils utils = new HW1Library.Utils();
            while (true)
            {
                Console.WriteLine("Введите целое число");
                string input = Console.ReadLine();
                var s = utils.OddOrEvenAnalyzer(input);
                Console.WriteLine($"Ответ: {s.ToString()}");
            }
        }
    }
}
