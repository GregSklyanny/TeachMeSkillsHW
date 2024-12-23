using System;
using static System.Collections.Specialized.BitVector32;


namespace TMSLesson3Library
{
    public class SumOperator : IMathOperator
    {
        private float a, b;
        public  SumOperator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public string Solve() => $"{a} + {b} = {a + b}";
    }

    public class SubtractionOperator : IMathOperator
    {
        private float a, b;
        public SubtractionOperator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public string Solve() => $"{a} - {b} = {a - b}";
    }

    public class MultiplicationOperator : IMathOperator
    {
        private float a, b;
        public MultiplicationOperator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public string Solve() => $"{a} * {b} = {a * b}";
    }

    public class DivisionOperator : IMathOperator
    {
        private float a, b;
        public DivisionOperator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public string Solve() => $"{a} / {b} = {a / b}";
    }

    public class PercentageOperator : IMathOperator
    {
        private float a, b;
        public PercentageOperator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public string Solve() => $"Число {a} составляет {a * 100 / b}% от числа {b}";
    }

    public class SqrtOperator : IMathOperator
    {
        private float a;
        public SqrtOperator(float a)
        {
            this.a = a;
        }

        public string Solve() => $"Корень квадратный числа {a} = {Math.Sqrt(a)}";
        }

}
