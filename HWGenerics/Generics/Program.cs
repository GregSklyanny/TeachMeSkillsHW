namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stringStack = new();
            MyStack<int> intStack = new();
            stringStack.Push("abc");
            stringStack.Push("cde");

            Console.WriteLine(stringStack.Pop());
            Console.WriteLine(stringStack.Peek());
            stringStack.Pop();
            stringStack.Push("fff");
            Console.WriteLine(stringStack.Pop());
            try {
                stringStack.Pop();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            stringStack.Push("a");
            stringStack.Push("b");
            stringStack.Push("c");

            Console.WriteLine(stringStack.Peek());


            intStack.Push(10);
            intStack.Push(20);
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Peek());
            intStack.Pop();
            try
            {
                intStack.Pop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
