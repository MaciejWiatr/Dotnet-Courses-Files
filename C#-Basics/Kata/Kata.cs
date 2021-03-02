using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class Kata
    {

        public static string Join(List<string> list, char separator)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
                if (i != list.Count - 1)
                {

                    sb.Append(separator);
                }
            }

            return sb.ToString();
        }

        public static List<string> Reverse(List<string> list)
        {
            var newList = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                newList.Add(list[i]);
            }
            return newList;
        }

        public static List<string> Split(string input, char separator)
        {
            var result = new List<string>();
            var currentIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == separator)
                {
                    var word = input.Substring(currentIndex, i - currentIndex);
                    result.Add(word);
                    currentIndex = i + 1; //skip separator by adding 1 to i 
                }
                else if (i == input.Length - 1)
                {
                    var word = input.Substring(currentIndex, input.Length - currentIndex);
                    result.Add(word);
                }
            }
            return result;
        }

        public static string ReverseWords(string str)
        {
            var splitWords = Split(str, ' ');
            var reversedWords = Reverse(splitWords);
            var result = Join(reversedWords, ' ');
            return result;
        }
    }
}
