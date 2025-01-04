namespace ulearn.me
{
    public class Task1
    {
        // Четный массив
        // https://ulearn.me/course/basicprogramming/Chetnyy_massiv_ceb81eac-069c-4d5d-87b7-ebd9b140e143

        public static int[] GetFirstEvenNumbers(int count)
        {
            var mas = new int[count];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = (i + 1) * 2;
            }
            return mas;
        }
    }

    public class Task2
    {
        // Индекс максимума
        // https://ulearn.me/course/basicprogramming/Indeks_maksimuma_043015a0-0b28-4435-8079-21e4ca8e6526
        static double Min(double[] array)
        {
            var min = double.MaxValue;
            foreach (var item in array)
                if (item < min) min = item;
            return min;
        }
    }
    public class Task3
    {
        // Подсчет
        // https://ulearn.me/course/basicprogramming/Podschet_9eb1a5c2-135d-49a5-a922-0f3f91566080
        public static int GetElementCount(int[] items, int itemToCount)
        {
            int result = 0;
            foreach (int item in items)
                if (itemToCount == item) result++;
            return result;
        }
    }
    public class Task4
    {
        // Поиск массива в массиве
        // https://ulearn.me/course/basicprogramming/Poisk_massiva_v_massive_df8d1ca7-9aab-4816-8047-a834c6ca64d4
        public static bool ContainsAtIndex(int[] array, int[] subArray, int startIndex)
        {
            if (array.Length < subArray.Length + startIndex) return false;

            for (int i = 0; i < subArray.Length; i++)
                if (array[startIndex + i] != subArray[i]) return false;
            return true;
        }
    }
    public class Task5
    {
        // Карты Таро
        // https://ulearn.me/course/basicprogramming/Karty_Taro_26c265ba-ea70-4aa9-bf6b-5c215576a3ab
        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }
        private static string GetSuit(Suits suit)
        {
            return new[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];
        }
    }
    public class Task6
    {
        // Null не Null
        // https://ulearn.me/course/basicprogramming/Null_ili_ne_Null__05581efc-0377-438e-b6c6-90778d3c8922

        public static bool CheckFirstElement(int[] array)
        {
            return array != null && array.Length != 0 && array[0] == 0;
        }

    }
    public class Task7
    {
        // Возвести массив в степень
        // https://ulearn.me/course/basicprogramming/Vozvesti_massiv_v_stepen__e3e45ec7-7bd0-4284-8ca1-0fbcb2fa0c21

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            var output = new int[arr.Length];
            Array.Copy(arr, output, arr.Length);
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = (int)Math.Pow(output[i], power);
            }
            return output;
        }
    }
    public class Task8
    {
        // Крестики-нолики
        // https://ulearn.me/course/basicprogramming/_Krestiki_noliki_b4f3138d-5cdb-4f8a-9976-e0f4d379687a

        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }
        public static GameResult GetGameResult(Mark[,] field)
        {
            int result = 0;
            result += GetResult(field, 0, 0, 0, 1);
            result += GetResult(field, 1, 0, 0, 1);
            result += GetResult(field, 2, 0, 0, 1);
            result += GetResult(field, 0, 0, 1, 0);
            result += GetResult(field, 0, 1, 1, 0);
            result += GetResult(field, 0, 2, 1, 0);
            result += GetResult(field, 0, 0, 1, 1);
            result += GetResult(field, 0, 2, 1, -1);

            if (result > 100 && result % 100 != 0) return GameResult.Draw;
            if (result >= 100) return GameResult.CircleWin;
            if (result > 0) return GameResult.CrossWin;

            return GameResult.Draw;
        }
        public static int GetResult(Mark[,] field, int x, int y, int dx, int dy)
        {
            GameResult result = CheckLine(field, x, y, dx, dy);
            if (result == GameResult.CircleWin) return 100;
            if (result == GameResult.CrossWin) return 1;
            return 0;
        }
        public static GameResult CheckLine(Mark[,] field, int x, int y, int dx, int dy)
        {
            int result = 1;
            for (int i = 0; i < 3; i++)
            {
                result *= (int)field[x + dx * i, y + dy * i];
            }
            if (result == 1) return GameResult.CrossWin;
            if (result == 8) return GameResult.CircleWin;
            return GameResult.Draw;
        }

    }
    public class Task9
    {
        // Практика Гистограмма
        // https://ulearn.me/course/basicprogramming/Praktika_Gistogramma__2657d334-82d7-460f-a5e5-5910ce95372e

        /*
        using System.Linq;

        namespace Names;

        internal static class HistogramTask
        {
            public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
            {
                var birthsInDays = new double[31];
                foreach (var person in names)
                {
                    if (person.Name == name)
                        birthsInDays[person.BirthDate.Day-1]++;
                }
                birthsInDays[0] = 0;
                return new HistogramData(
                    $"Рождаемость людей с именем '{name}'",
                    Enumerable.Range(1, 31).Select(n => n.ToString()).ToArray(),
                    birthsInDays);
            }
        }
     */
    }
    public class Task10
    {
        // Практика Тепловая карта
        // https://ulearn.me/course/basicprogramming/Praktika_Teplovaya_karta__a7b3118a-cb3d-4715-b03a-a31a7c3ea9ec

        /*
        using System.Linq;
        using System.Xml.Linq;

        namespace Names;

            internal static class HeatmapTask
            {
                public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
                {
                    var array = new double[30, 12];

                    foreach (var person in names)
                    {
                        if (person.BirthDate.Day == 1) continue;
                        array[person.BirthDate.Day - 2, person.BirthDate.Month - 1]++;
                    }
                    return new HeatmapData(
                        "Пример карты интенсивностей",
                        array,
                        Enumerable.Range(2, 30).Select(n => n.ToString()).ToArray(),
                        Enumerable.Range(1, 12).Select(n => n.ToString()).ToArray());
                }
            }
        */
    }

}
