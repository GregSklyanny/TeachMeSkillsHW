using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{

    public class Utils
    {
        public static string TransformArrayToString(int[,] array)
        {
            StringBuilder sb = new StringBuilder();
            int m = array.GetLength(0);
            int n = array.GetLength(1);
            //выводим массив
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    sb.Append(array[x, y]);
                    sb.Append(' ');
                }
                sb.Append('\n');

            }
            return sb.ToString();
        }

        public static int[,] ReverseLine(int[,] array, int i)
        {
            var list = new List<int>();
            int dim = array.GetLength(1);
            if (dim - 1 < i || i < 0) throw new ArgumentException("Неверный индекс строки");
            for (int k = 0; k < dim; k++)
            {
                list.Add(array[i, k]);
            }
            list.Reverse();
            for (int k = 0; k < dim; k++)
            {
                array[i,k] = list[k];
            }
            return array;
        }
        public static int[,] SortAscending(int[,] array, int i)
        {
            var list = new List<int>();
            int dim = array.GetLength(1);
            if (dim - 1 < i || i < 0) throw new ArgumentException("Неверный индекс строки");
            for (int k = 0; k < dim; k++)
            {
                list.Add(array[i, k]);
            }
            list.Sort((a,b) => a - b);
            for (int k = 0; k < dim; k++)
            {
                array[i, k] = list[k];
            }
            return array;
        }
        public static int[,] SortDescending(int[,] array, int i)
        {
            var list = new List<int>();
            int dim = array.GetLength(1);
            if (dim - 1 < i || i < 0) throw new ArgumentException("Неверный индекс строки");
            for (int k = 0; k < dim; k++)
            {
                list.Add(array[i, k]);
            }
            list.Sort((a, b) => b - a);
            for (int k = 0; k < dim; k++)
            {
                array[i, k] = list[k];
            }
            return array;
        }
        public static string NegativeAndPositiveCount(int[,] array)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);
            int negativeCount = 0 , positiveCount = 0;
            //выводим массив
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (array[x,y] >= 0)
                    {
                        positiveCount++;
                    }
                    else
                    {
                        negativeCount++;
                    }
                }
            }
            return $"Положительных чисел = {positiveCount}, отрицательных чисел = {negativeCount}";
        }
    }
}
