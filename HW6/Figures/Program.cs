namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape> {
                new Circle("Круг", 10d),
                new Square("Квадрат", 2d)
            };
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
            }

        }
    }
}
