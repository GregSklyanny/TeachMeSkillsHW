using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleStringMethods
{
    public class Utils
    {
        private static char[]  _splitFilter = new char[] { '!', '?', '.' ,',', ' '};
        public static string[] ParseSentencesRegex(string input)
        {
            string[] strings = Regex.Split(input, @"(?<=[\.!\?])\s+");
            return strings;
        }
        public static string[] ParseSentences(string input)
        {
            var list = new List<string>();
            var startingPointer = -1;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '?' || input[i] == '.' || input[i] == '!')
                {
                    list.Add(input.Substring(startingPointer + 1, i - startingPointer));
                    startingPointer = i;
                }
            }
            if(!input.EndsWith('?') && !input.EndsWith('.') && !input.EndsWith('!'))
                list.Add(input.Substring(startingPointer + 1, input.Length - 1 - startingPointer));
            return list.ToArray();
        }
        public static string CheckMaxDigits(string input)
        {
            string[] strings = input.Split(_splitFilter, StringSplitOptions.RemoveEmptyEntries);
            int maxCountOfDigits = -1;
            string wordWithMaxCountOfDigits = "";

            for (int i = 0; i < strings.Length; i++)
            {
                int currentCount = 0;
                foreach(char ch in strings[i])
                {
                    if (char.IsDigit(ch)) currentCount++;
                }
                if(currentCount > maxCountOfDigits)
                {
                    maxCountOfDigits = currentCount;
                    wordWithMaxCountOfDigits = strings[i];
                }
            }
            return $"Слово \"{wordWithMaxCountOfDigits}\" имеет больше всего цифр - {maxCountOfDigits} ";
        }
        public static string CheckLongWordAndAppearance(string input)
        {
            var strings = input.Split(_splitFilter, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(strings, (a, b) => a.Length - b.Length);
            int count = strings.GroupBy(g => g).Where(g => g.Key == strings[strings.Length-1]).First().Count();
            return $"Слово {strings[strings.Length - 1]} имеет длину {strings[strings.Length - 1].Length} и встречается в тексте {count} раз";
        }
        public static string SwapDigitsToWords(string input)
        {
            var dict = new Dictionary<string, string>() 
            {
                { "0", "ноль" }, 
                { "1", "один" }, 
                { "2", "два" }, 
                { "3", "три" }, 
                { "4", "четыре" }, 
                { "5", "пять" }, 
                { "6", "шесть" }, 
                { "7", "семь" }, 
                { "8", "восемь" }, 
                { "9", "девять" }
            };
            var sb = new StringBuilder(input);

            for(int i = 0; i < 10; i++)
            {
                sb = sb.Replace(i.ToString(), dict[i.ToString()]);
            }
            return sb.ToString();
        }
        public static string AffirmativeAndQuestions(string input)
        {
            StringBuilder result = new StringBuilder();
            var strings = ParseSentences(input);
            for(int i = 0; i < strings.Length; i++)
            {
                if (strings[i].EndsWith('?'))
                    result.Append(strings[i] + " ");
            }
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].EndsWith('.'))
                    result.Append(strings[i] + " ");
            }
            return result.ToString();
        }
        public static string NotContainsCommasSentences(string input)
        {
            StringBuilder result = new StringBuilder();
            var strings = ParseSentences(input);

            for (int i = 0; i < strings.Length; i++)
            {
                if (!strings[i].Contains(','))
                    result.Append(strings[i] + " ");
            }
            return result.ToString();
        }
        public static string BeginAndEndsWithTheSameLetter(string input)
        {
            StringBuilder result = new StringBuilder();
            string[] strings = input.Split(_splitFilter, StringSplitOptions.RemoveEmptyEntries);
            foreach(string word in strings)
            {
                if (word[0] == word[word.Length-1])
                    result.Append(word + " ");
            }
            return result.ToString();
        }
    }
}
