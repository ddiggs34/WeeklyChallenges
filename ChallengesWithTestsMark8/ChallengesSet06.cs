using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || string.IsNullOrEmpty(word))
            {
                // Handle null collection or empty word if needed
                return false;
            }

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (string item in words)
            {
                if (string.Equals(item, word, comparison))
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false; 
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null || str.Length == 0)
            {
                // Handle null or empty string if needed
                return -1;
            }

            int lastIndex = -1;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];

                if (str.LastIndexOf(currentChar) == i)
                {
                    lastIndex = i;
                    break;
                }
            }

            return lastIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int currentCount = 1;
            int maxCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return Array.Empty<double>();
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
