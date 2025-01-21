namespace HWExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            var login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            var password = Console.ReadLine();
            Console.WriteLine("Подтвердите пароль");
            var passwordConfirmation = Console.ReadLine();

            var result = InputValidator.IsInputCorrect(login, password, passwordConfirmation);
            Console.WriteLine(result);
        }
    }
}
