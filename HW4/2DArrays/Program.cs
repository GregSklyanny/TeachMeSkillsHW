using System.Text;

namespace _2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            bool flag = true;

            while (flag)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Введите размерность:");
                    Console.Write("Количество строк = ");
                    if (!int.TryParse(Console.ReadLine(), out m)) throw new ArgumentException("неверно введено значение");
                    Console.Write("Количество столбцов = ");
                    if (!int.TryParse(Console.ReadLine(), out n)) throw new ArgumentException("неверно введено значение");

                    var array = new int[m, n];
                    Console.WriteLine("Введите значения:");
                    for (int x = 0; x < m; x++)
                    {
                        Console.WriteLine($"{x+1} строка");
                        for (int y = 0; y < n; y++)
                        {
                            if (!int.TryParse(Console.ReadLine(), out array[x, y])) throw new ArgumentException("неверно введено значение");
                            
                        }
                        
                    }
                    Console.WriteLine("Итоговая матрица");
                    Console.WriteLine(Utils.TransformArrayToString(array));

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
                            case "rev":
                                Console.WriteLine("реверс какой строки?");
                                int param = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Utils.ReverseLine(array, param);
                                Console.WriteLine(Utils.TransformArrayToString(array));
                                break;
                            case "sortAsc":
                                Console.WriteLine("реверс какой строки?");
                                param = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Utils.SortAscending(array, param);
                                Console.WriteLine(Utils.TransformArrayToString(array));
                                break;
                            case "sortDesc":
                                Console.WriteLine("реверс какой строки?");
                                param = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Utils.SortDescending(array, param);
                                Console.WriteLine(Utils.TransformArrayToString(array));
                                break;
                            case "+-":
                                Console.WriteLine(Utils.NegativeAndPositiveCount(array));
                                break;
                            default:
                                throw new ArgumentException("такой команды не существует");
                        }
                        
                    }
                    Console.Clear();

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
