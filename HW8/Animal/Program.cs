namespace Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя собаки");
            var name = Console.ReadLine();
            var dog = new Dog();
            dog.SetName(name);
            Console.WriteLine($"вы дали собаке кличку {dog.GetName()}");
            dog.Eat();
        }
    }
}
