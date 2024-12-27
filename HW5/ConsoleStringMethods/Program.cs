namespace ConsoleStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string[] sentences;

            while (flag)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Введите текст");
                    string text = Console.ReadLine().Trim();
                    sentences = Utils.ParseSentences(text);
                    bool flag2 = true;
                    string str = "Выберите действие: \n q - выйти \n maxDigits - найти слово с наибольшим количеством цифр \n maxWidth - найти самое длинное слово и узнать сколько раз оно появлялось в тексте" +
                        "\n replaceDigits - заменить цифры от 0 до 9 на слова ноль, один и тд \n ?. - вывести сначала вопросительные, затем восклицательные предложения" +
                        "\n -, - вывести предложения не содержащие запятых \n sameLetters - вывести слова, начинающиеся на одну и ту же букву";
                    while (flag2)
                    {
                        Console.WriteLine(str);
                        string action = Console.ReadLine();
                        switch(action)
                        {
                            case "q":
                                flag2 = false;
                                break;
                            case "maxDigits":
                                Console.WriteLine(Utils.CheckMaxDigits(text));
                                break;
                            case "maxWidth":
                                Console.WriteLine(Utils.CheckLongWordAndAppearance(text));
                                break;
                            case "replaceDigits":
                                Console.WriteLine(Utils.SwapDigitsToWords(text));
                                break;
                            case "?.":
                                Console.WriteLine(Utils.AffirmativeAndQuestions(text));
                                break;
                            case "-,":
                                Console.WriteLine(Utils.NotContainsCommasSentences(text));
                                break;
                            case "sameLetters":
                                Console.WriteLine(Utils.BeginAndEndsWithTheSameLetter(text));
                                break;
                            default:
                                throw new ArgumentException("такой команды не существует");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = IsNeedRestart();
                    Console.Clear();
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