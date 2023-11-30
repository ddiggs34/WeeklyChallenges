using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber < 0 || n <= 0)
            {
                return -1;
            }

            int nextNumber = startNumber;

            while (nextNumber % n != 0)
            {
                nextNumber++;
            }

            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
            {
                return true;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }


        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            string sentence = string.Join(" ", words);

            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1) + ".";

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return Array.Empty<double>();
            }

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;

                if (seenNumbers.Contains(complement))
                {
                    return true; 
                }

                seenNumbers.Add(num);
            }

            return false;
        }
    }
}
