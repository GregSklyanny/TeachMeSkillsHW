namespace ConsoleStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Введите текст");
                    string text = Console.ReadLine();

                    bool flag2 = true;
                    string str = "Выберите действие: \n q - выйти \n rev - реверс строки массива \n +- - количество положительных и отриательных элементов" +
                        "\n sortAsc - сортировка по возрастанию \n sortDesc - сортировка по убыванию";
                    while (flag2)
                    {
                        Console.WriteLine(str);
                        string action = Console.ReadLine();
                        switch(action)
                        {
                            case "q":
                                flag2 = false;
                                break;
                            default:
                                throw new ArgumentException("такой команды не существует");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    flag = IsNeedRestart();
                }

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