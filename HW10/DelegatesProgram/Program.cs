﻿namespace DelegatesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var opManager = new OperationManager(20, 10);
            var result = opManager.executionManager.FuncExecute[Operation.Sum]();
            Console.WriteLine($"The result of the operation is {result}");
            Console.ReadKey();
        }
    }
}
